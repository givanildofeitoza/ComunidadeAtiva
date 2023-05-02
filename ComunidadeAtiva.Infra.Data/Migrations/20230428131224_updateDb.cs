using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComunidadeAtiva.Infra.Data.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdRua",
                table: "morador",
                newName: "RuaId");

            migrationBuilder.CreateIndex(
                name: "IX_morador_RuaId",
                table: "morador",
                column: "RuaId");

            migrationBuilder.AddForeignKey(
                name: "FK_morador_rua_RuaId",
                table: "morador",
                column: "RuaId",
                principalTable: "rua",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_morador_rua_RuaId",
                table: "morador");

            migrationBuilder.DropIndex(
                name: "IX_morador_RuaId",
                table: "morador");

            migrationBuilder.RenameColumn(
                name: "RuaId",
                table: "morador",
                newName: "IdRua");
        }
    }
}
