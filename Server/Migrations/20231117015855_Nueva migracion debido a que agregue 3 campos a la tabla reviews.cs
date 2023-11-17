﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AguaMariaSolution.Server.Migrations
{
    /// <inheritdoc />
    public partial class Nuevamigraciondebidoaqueagregue3camposalatablareviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Reviews",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Reviews",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Reviews",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Reviews");
        }
    }
}
