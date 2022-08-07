using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.MercadoLivre.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema("MercadoLivre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSchema("MercadoLivre");
        }
    }
}
