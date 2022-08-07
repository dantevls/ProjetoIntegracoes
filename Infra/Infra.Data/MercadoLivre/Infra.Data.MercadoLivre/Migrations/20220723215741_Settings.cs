using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.MercadoLivre.Migrations
{
    /// <inheritdoc />
    public partial class Settings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UsuarioMercadoLivre",
                newName: "UsuarioMercadoLivre",
                newSchema: "MercadoLivre");

            migrationBuilder.RenameTable(
                name: "Plano",
                newName: "Plano",
                newSchema: "MercadoLivre");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "MercadoLivre",
                table: "UsuarioMercadoLivre",
                newName: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UsuarioMercadoLivre",
                schema: "MercadoLivre",
                newName: "UsuarioMercadoLivre");

            migrationBuilder.RenameTable(
                name: "Plano",
                schema: "MercadoLivre",
                newName: "Plano");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "UsuarioMercadoLivre",
                newName: "Id");
        }
    }
}
