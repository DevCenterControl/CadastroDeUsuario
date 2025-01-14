﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroDeUsuario_Infra.Migrations
{
    /// <inheritdoc />
    public partial class Migration001ColunaIdade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idade",
                table: "Users");
        }
    }
}
