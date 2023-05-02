using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComunidadeAtiva.Infra.Data.Migrations
{
    public partial class updateChaves : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdPrograma",
                table: "moradorPrograma",
                newName: "ProgramaId");

            migrationBuilder.RenameColumn(
                name: "IdMorador",
                table: "moradorPrograma",
                newName: "MoradorId");

            migrationBuilder.RenameColumn(
                name: "IdNecessidade",
                table: "moradorNecessidadeEspecial",
                newName: "NecessidadeId");

            migrationBuilder.RenameColumn(
                name: "IdMorador",
                table: "moradorNecessidadeEspecial",
                newName: "MoradorId");

            migrationBuilder.RenameColumn(
                name: "IdMorador",
                table: "moradorBeneficioSocial",
                newName: "MoradorId");

            migrationBuilder.RenameColumn(
                name: "IdBeneficioSocial",
                table: "moradorBeneficioSocial",
                newName: "BeneficioSocialId");

            migrationBuilder.CreateIndex(
                name: "IX_moradorPrograma_MoradorId",
                table: "moradorPrograma",
                column: "MoradorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_moradorNecessidadeEspecial_MoradorId",
                table: "moradorNecessidadeEspecial",
                column: "MoradorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_moradorBeneficioSocial_MoradorId",
                table: "moradorBeneficioSocial",
                column: "MoradorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_moradorBeneficioSocial_morador_MoradorId",
                table: "moradorBeneficioSocial",
                column: "MoradorId",
                principalTable: "morador",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_moradorNecessidadeEspecial_morador_MoradorId",
                table: "moradorNecessidadeEspecial",
                column: "MoradorId",
                principalTable: "morador",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_moradorPrograma_morador_MoradorId",
                table: "moradorPrograma",
                column: "MoradorId",
                principalTable: "morador",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_moradorBeneficioSocial_morador_MoradorId",
                table: "moradorBeneficioSocial");

            migrationBuilder.DropForeignKey(
                name: "FK_moradorNecessidadeEspecial_morador_MoradorId",
                table: "moradorNecessidadeEspecial");

            migrationBuilder.DropForeignKey(
                name: "FK_moradorPrograma_morador_MoradorId",
                table: "moradorPrograma");

            migrationBuilder.DropIndex(
                name: "IX_moradorPrograma_MoradorId",
                table: "moradorPrograma");

            migrationBuilder.DropIndex(
                name: "IX_moradorNecessidadeEspecial_MoradorId",
                table: "moradorNecessidadeEspecial");

            migrationBuilder.DropIndex(
                name: "IX_moradorBeneficioSocial_MoradorId",
                table: "moradorBeneficioSocial");

            migrationBuilder.RenameColumn(
                name: "ProgramaId",
                table: "moradorPrograma",
                newName: "IdPrograma");

            migrationBuilder.RenameColumn(
                name: "MoradorId",
                table: "moradorPrograma",
                newName: "IdMorador");

            migrationBuilder.RenameColumn(
                name: "NecessidadeId",
                table: "moradorNecessidadeEspecial",
                newName: "IdNecessidade");

            migrationBuilder.RenameColumn(
                name: "MoradorId",
                table: "moradorNecessidadeEspecial",
                newName: "IdMorador");

            migrationBuilder.RenameColumn(
                name: "MoradorId",
                table: "moradorBeneficioSocial",
                newName: "IdMorador");

            migrationBuilder.RenameColumn(
                name: "BeneficioSocialId",
                table: "moradorBeneficioSocial",
                newName: "IdBeneficioSocial");
        }
    }
}
