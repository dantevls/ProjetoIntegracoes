using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.MercadoLivre.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureMercadoLivreMappings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MercadoLivreAnuncio_Plano_PlanoId",
                table: "MercadoLivreAnuncio");

            migrationBuilder.DropForeignKey(
                name: "FK_MercadoLivreAnuncio_SistemaExterno_SistemaExternoId",
                table: "MercadoLivreAnuncio");

            migrationBuilder.DropForeignKey(
                name: "FK_MercadoLivreAnuncio_UsuarioMercadoLivre_UsuarioId",
                table: "MercadoLivreAnuncio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MercadoLivreAnuncio",
                table: "MercadoLivreAnuncio");

            migrationBuilder.DropColumn(
                name: "SistemaExternoId",
                table: "Plano");

            migrationBuilder.EnsureSchema(
                name: "MercadoLivre");

            migrationBuilder.RenameTable(
                name: "MercadoLivreAnuncio",
                newName: "Anuncio",
                newSchema: "MercadoLivre");

            migrationBuilder.RenameIndex(
                name: "IX_MercadoLivreAnuncio_UsuarioId",
                schema: "MercadoLivre",
                table: "Anuncio",
                newName: "IX_Anuncio_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_MercadoLivreAnuncio_SistemaExternoId",
                schema: "MercadoLivre",
                table: "Anuncio",
                newName: "IX_Anuncio_SistemaExternoId");

            migrationBuilder.RenameIndex(
                name: "IX_MercadoLivreAnuncio_PlanoId",
                schema: "MercadoLivre",
                table: "Anuncio",
                newName: "IX_Anuncio_PlanoId");

            migrationBuilder.AddColumn<string>(
                name: "Destaque",
                table: "Plano",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Plano",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Anuncio",
                schema: "MercadoLivre",
                table: "Anuncio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Anuncio_Plano_PlanoId",
                schema: "MercadoLivre",
                table: "Anuncio",
                column: "PlanoId",
                principalTable: "Plano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Anuncio_SistemaExterno_SistemaExternoId",
                schema: "MercadoLivre",
                table: "Anuncio",
                column: "SistemaExternoId",
                principalTable: "SistemaExterno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Anuncio_UsuarioMercadoLivre_UsuarioId",
                schema: "MercadoLivre",
                table: "Anuncio",
                column: "UsuarioId",
                principalTable: "UsuarioMercadoLivre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anuncio_Plano_PlanoId",
                schema: "MercadoLivre",
                table: "Anuncio");

            migrationBuilder.DropForeignKey(
                name: "FK_Anuncio_SistemaExterno_SistemaExternoId",
                schema: "MercadoLivre",
                table: "Anuncio");

            migrationBuilder.DropForeignKey(
                name: "FK_Anuncio_UsuarioMercadoLivre_UsuarioId",
                schema: "MercadoLivre",
                table: "Anuncio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Anuncio",
                schema: "MercadoLivre",
                table: "Anuncio");

            migrationBuilder.DropColumn(
                name: "Destaque",
                table: "Plano");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Plano");

            migrationBuilder.RenameTable(
                name: "Anuncio",
                schema: "MercadoLivre",
                newName: "MercadoLivreAnuncio");

            migrationBuilder.RenameIndex(
                name: "IX_Anuncio_UsuarioId",
                table: "MercadoLivreAnuncio",
                newName: "IX_MercadoLivreAnuncio_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Anuncio_SistemaExternoId",
                table: "MercadoLivreAnuncio",
                newName: "IX_MercadoLivreAnuncio_SistemaExternoId");

            migrationBuilder.RenameIndex(
                name: "IX_Anuncio_PlanoId",
                table: "MercadoLivreAnuncio",
                newName: "IX_MercadoLivreAnuncio_PlanoId");

            migrationBuilder.AddColumn<Guid>(
                name: "SistemaExternoId",
                table: "Plano",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_MercadoLivreAnuncio",
                table: "MercadoLivreAnuncio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MercadoLivreAnuncio_Plano_PlanoId",
                table: "MercadoLivreAnuncio",
                column: "PlanoId",
                principalTable: "Plano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MercadoLivreAnuncio_SistemaExterno_SistemaExternoId",
                table: "MercadoLivreAnuncio",
                column: "SistemaExternoId",
                principalTable: "SistemaExterno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MercadoLivreAnuncio_UsuarioMercadoLivre_UsuarioId",
                table: "MercadoLivreAnuncio",
                column: "UsuarioId",
                principalTable: "UsuarioMercadoLivre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
