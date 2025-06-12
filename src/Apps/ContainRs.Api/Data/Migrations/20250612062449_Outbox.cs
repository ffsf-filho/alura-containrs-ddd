using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContainRs.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Outbox : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Endereco_Clientes_ClienteId",
            //    table: "Endereco");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Solicitacoes_Endereco_EnderecoId",
            //    table: "Solicitacoes");

            //migrationBuilder.DropIndex(
            //    name: "IX_Solicitacoes_EnderecoId",
            //    table: "Solicitacoes");

            //migrationBuilder.DropIndex(
            //    name: "IX_Endereco_ClienteId",
            //    table: "Endereco");

            //migrationBuilder.DropColumn(
            //    name: "Bairro",
            //    table: "Endereco");

            //migrationBuilder.DropColumn(
            //    name: "ClienteId",
            //    table: "Endereco");

            //migrationBuilder.DropColumn(
            //    name: "Complemento",
            //    table: "Endereco");

            //migrationBuilder.DropColumn(
            //    name: "Estado",
            //    table: "Endereco");

            //migrationBuilder.DropColumn(
            //    name: "Municipio",
            //    table: "Endereco");

            //migrationBuilder.DropColumn(
            //    name: "Nome",
            //    table: "Endereco");

            //migrationBuilder.DropColumn(
            //    name: "Rua",
            //    table: "Endereco");

            //migrationBuilder.DropColumn(
            //    name: "Situacao",
            //    table: "Conteineres");

            //migrationBuilder.RenameColumn(
            //    name: "ValorTotal",
            //    table: "Propostas",
            //    newName: "ValorTotal_Valor");

            //migrationBuilder.RenameColumn(
            //    name: "Numero",
            //    table: "Endereco",
            //    newName: "Referencias");

            //migrationBuilder.AddColumn<int>(
            //    name: "LocalizacaoId",
            //    table: "Solicitacoes",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AlterColumn<int>(
            //    name: "Id",
            //    table: "Endereco",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(Guid),
            //    oldType: "uniqueidentifier")
            //    .Annotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddColumn<double>(
            //    name: "Latitude",
            //    table: "Endereco",
            //    type: "float",
            //    nullable: true);

            //migrationBuilder.AddColumn<double>(
            //    name: "Longitude",
            //    table: "Endereco",
            //    type: "float",
            //    nullable: true);

            //migrationBuilder.AddColumn<Guid>(
            //    name: "LocacaoId",
            //    table: "Conteineres",
            //    type: "uniqueidentifier",
            //    nullable: false,
            //    defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            //migrationBuilder.AddColumn<int>(
            //    name: "Status",
            //    table: "Conteineres",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateTable(
            //    name: "EnderecoCli",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_EnderecoCli", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_EnderecoCli_Clientes_ClienteId",
            //            column: x => x.ClienteId,
            //            principalTable: "Clientes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateTable(
                name: "Outbox",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoEvento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoEvento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outbox", x => x.Id);
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Solicitacoes_LocalizacaoId",
            //    table: "Solicitacoes",
            //    column: "LocalizacaoId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_EnderecoCli_ClienteId",
            //    table: "EnderecoCli",
            //    column: "ClienteId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Solicitacoes_Endereco_LocalizacaoId",
            //    table: "Solicitacoes",
            //    column: "LocalizacaoId",
            //    principalTable: "Endereco",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Solicitacoes_Endereco_LocalizacaoId",
            //    table: "Solicitacoes");

            //migrationBuilder.DropTable(
            //    name: "EnderecoCli");

            migrationBuilder.DropTable(
                name: "Outbox");

            //migrationBuilder.DropIndex(
            //    name: "IX_Solicitacoes_LocalizacaoId",
            //    table: "Solicitacoes");

            //migrationBuilder.DropColumn(
            //    name: "LocalizacaoId",
            //    table: "Solicitacoes");

            //migrationBuilder.DropColumn(
            //    name: "Latitude",
            //    table: "Endereco");

            //migrationBuilder.DropColumn(
            //    name: "Longitude",
            //    table: "Endereco");

            //migrationBuilder.DropColumn(
            //    name: "LocacaoId",
            //    table: "Conteineres");

            //migrationBuilder.DropColumn(
            //    name: "Status",
            //    table: "Conteineres");

            //migrationBuilder.RenameColumn(
            //    name: "ValorTotal_Valor",
            //    table: "Propostas",
            //    newName: "ValorTotal");

            //migrationBuilder.RenameColumn(
            //    name: "Referencias",
            //    table: "Endereco",
            //    newName: "Numero");

            //migrationBuilder.AlterColumn<Guid>(
            //    name: "Id",
            //    table: "Endereco",
            //    type: "uniqueidentifier",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddColumn<string>(
            //    name: "Bairro",
            //    table: "Endereco",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.AddColumn<Guid>(
            //    name: "ClienteId",
            //    table: "Endereco",
            //    type: "uniqueidentifier",
            //    nullable: false,
            //    defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            //migrationBuilder.AddColumn<string>(
            //    name: "Complemento",
            //    table: "Endereco",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Estado",
            //    table: "Endereco",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Municipio",
            //    table: "Endereco",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "Nome",
            //    table: "Endereco",
            //    type: "nvarchar(max)",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Rua",
            //    table: "Endereco",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "Situacao",
            //    table: "Conteineres",
            //    type: "nvarchar(max)",
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Solicitacoes_EnderecoId",
            //    table: "Solicitacoes",
            //    column: "EnderecoId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Endereco_ClienteId",
            //    table: "Endereco",
            //    column: "ClienteId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Endereco_Clientes_ClienteId",
            //    table: "Endereco",
            //    column: "ClienteId",
            //    principalTable: "Clientes",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Solicitacoes_Endereco_EnderecoId",
            //    table: "Solicitacoes",
            //    column: "EnderecoId",
            //    principalTable: "Endereco",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
