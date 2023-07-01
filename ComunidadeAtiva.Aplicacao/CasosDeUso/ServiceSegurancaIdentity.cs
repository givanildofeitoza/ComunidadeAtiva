using ComunidadeAtiva.Aplicacao.CasosDeUso.Interface;
using ComunidadeAtiva.Aplicacao.DTO;
using ComunidadeAtiva.Dominio.Interfaces;
using ComunidadeAtiva.Dominio.Validacao;
using ComunidadeAtiva.Aplicacao.ClasseConfig;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;

namespace ComunidadeAtiva.Aplicacao.CasosDeUso
{
    public class ServiceSegurancaIdentity : IServiceSegurancaIdentity
    {
        protected readonly UserManager<IdentityUser> _UserManager;
        private readonly SignInManager<IdentityUser> _SignInManager;
        private readonly ICapturarNotificacao _notificacao;
        private readonly IServicoCorpoDirigenteAssociacao _CorpoDirigenteAssociacao;
        private readonly AppSetingsJWT _appSettings;

        public ServiceSegurancaIdentity(UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager,
            ICapturarNotificacao notificacao,
            IServicoCorpoDirigenteAssociacao CorpoDirigenteAssociacao,
            IOptions<AppSetingsJWT> appSettings)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
            _notificacao = notificacao;
            _CorpoDirigenteAssociacao = CorpoDirigenteAssociacao;
            _appSettings = appSettings.Value;
        }
     
        public async Task CriarUsuario(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {
            _notificacao.LimparErros();

            if (dirigenteDto == null)
            {               
                _notificacao.AddNotificacao("Houve um erro ao tentar fazer o registro de usuário/membro !");
                EmitirExcecoes.EmitirExcecao(_notificacao);
            }
            if (string.IsNullOrEmpty(dirigenteDto.Nome))
            {               
                _notificacao.AddNotificacao("Informe o nome do usuário/membro !");
                EmitirExcecoes.EmitirExcecao(_notificacao);
            }
            var user = new IdentityUser
            {
                Email = dirigenteDto.Email,
                UserName = dirigenteDto.Email,
                EmailConfirmed = true               
            };
           
            var result = await _UserManager.CreateAsync(user, dirigenteDto.Senha);
            if (result.Succeeded)
            {
                user = await _UserManager.FindByEmailAsync(user.Email);
                dirigenteDto.UsuarioId = user.Id.ToString();
                await _CorpoDirigenteAssociacao.CadastrarDirigente(dirigenteDto);
            }
            else
            {
                _notificacao.LimparErros();
                foreach (var e in result.Errors)
                {
                    _notificacao.AddNotificacao(e.Description);
                    EmitirExcecoes.EmitirExcecao(_notificacao);                    
                }
            }
           
        }
        public async Task<string> FazerLoginForms(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {   
            var user = await _UserManager.FindByEmailAsync(dirigenteDto.Email);
            if(user == null)
            {
                _notificacao.LimparErros();
                _notificacao.AddNotificacao("Erro ao tentar entrar! Verifique usuário e senha!");
                EmitirExcecoes.EmitirExcecao(_notificacao);
            }
            var result = await _SignInManager.CheckPasswordSignInAsync(user, dirigenteDto.Senha, true);

            return user.Id;
        }
        public async Task<LoginDTO> FazerLoginWebApi(LoginDTO dirigenteDto)
        {           
            var result = await _SignInManager.PasswordSignInAsync(dirigenteDto.Email, dirigenteDto.Senha, false, true);
            if (result.Succeeded)
            {
                 dirigenteDto.TokenJwt = await CriarTokenJWT(dirigenteDto.Email);
                dirigenteDto.Status = "Logado";
            }
            else
            {
                _notificacao.LimparErros();
                _notificacao.AddNotificacao("Erro ao tentar entrar! Verifique usuário e senha!");
                EmitirExcecoes.EmitirExcecao(_notificacao);
            }

            return dirigenteDto;

        }
        public Task FazerLogoff(CorpoDirigenteAssociacaoDTO dirigenteDto)
        {
            throw new NotImplementedException();
        }
        public async Task<string> CriarTokenJWT(string email)
        {
            //para uso de claims
            var user = await _UserManager.FindByEmailAsync(email);
            var claims = await _UserManager.GetClaimsAsync(user);
            var userRoles = await _UserManager.GetRolesAsync(user);

            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.Id));
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));
            claims.Add(new Claim(JwtRegisteredClaimNames.GivenName, user.UserName));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Nbf, ToUnixEpochDate(DateTime.UtcNow).ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(DateTime.UtcNow).ToString(), ClaimValueTypes.Integer64));

            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim("role", userRole));
            }

            var identityClaims = new ClaimsIdentity();
            identityClaims.AddClaims(claims);
            //para uso de claims


            var tokenHandler = new JwtSecurityTokenHandler();
            //injetar a classe appSetings no construtor com IOptions<AppSettings>;

            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _appSettings.Emissor,
                Audience = _appSettings.ValidoEm,
                Subject = identityClaims,
                Expires = DateTime.UtcNow.AddHours(_appSettings.ExpiracaoHoras),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            });

            var encodedToken = tokenHandler.WriteToken(token);
            return encodedToken;

        }
        //para uso de claims
        private static long ToUnixEpochDate(DateTime date)
        => (long)Math.Round((date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);

    }
}
