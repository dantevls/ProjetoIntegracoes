using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.MercadoLivre.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plano",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    QtdAnuncios = table.Column<decimal>(type: "numeric", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    SistemaExternoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Control_DataInc = table.Column<string>(type: "text", nullable: false),
                    Control_DataAlter = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SistemaExterno",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemaExterno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioMercadoLivre",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: false),
                    Client_Secret = table.Column<string>(type: "text", nullable: false),
                    Client_Id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioMercadoLivre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MercadoLivreAnuncio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uuid", nullable: false),
                    PlanoId = table.Column<Guid>(type: "uuid", nullable: false),
                    SistemaExternoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Control_DataInc = table.Column<string>(type: "text", nullable: false),
                    Control_DataAlter = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MercadoLivreAnuncio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MercadoLivreAnuncio_Plano_PlanoId",
                        column: x => x.PlanoId,
                        principalTable: "Plano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MercadoLivreAnuncio_SistemaExterno_SistemaExternoId",
                        column: x => x.SistemaExternoId,
                        principalTable: "SistemaExterno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MercadoLivreAnuncio_UsuarioMercadoLivre_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "UsuarioMercadoLivre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MercadoLivreAnuncio_PlanoId",
                table: "MercadoLivreAnuncio",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_MercadoLivreAnuncio_SistemaExternoId",
                table: "MercadoLivreAnuncio",
                column: "SistemaExternoId");

            migrationBuilder.CreateIndex(
                name: "IX_MercadoLivreAnuncio_UsuarioId",
                table: "MercadoLivreAnuncio",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MercadoLivreAnuncio");

            migrationBuilder.DropTable(
                name: "Plano");

            migrationBuilder.DropTable(
                name: "SistemaExterno");

            migrationBuilder.DropTable(
                name: "UsuarioMercadoLivre");
        }
    }
}
