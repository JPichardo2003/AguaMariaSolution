﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AguaMariaSolution.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Contraseña = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "ControlCalidadAgua",
                columns: table => new
                {
                    ControlCalidadAguaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AcciónTomada = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    EntidadMuestreoAguaId = table.Column<int>(type: "INTEGER", nullable: false),
                    TandaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlCalidadAgua", x => x.ControlCalidadAguaId);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Dirección = table.Column<string>(type: "TEXT", nullable: false),
                    Clave = table.Column<string>(type: "TEXT", nullable: false),
                    Teléfono = table.Column<string>(type: "TEXT", nullable: false),
                    Celular = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "EntidadesMuestreoAguas",
                columns: table => new
                {
                    EntidadesMuestreoAguaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripción = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadesMuestreoAguas", x => x.EntidadesMuestreoAguaId);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    ParametroId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripción = table.Column<string>(type: "TEXT", nullable: false),
                    Mínimo = table.Column<float>(type: "REAL", nullable: false),
                    Máximo = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.ParametroId);
                });

            migrationBuilder.CreateTable(
                name: "Referencias",
                columns: table => new
                {
                    ReferenciaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParametroId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripción = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referencias", x => x.ReferenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", nullable: false),
                    Valoración = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaDeBotellon = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControlCalidadAguaDetalle",
                columns: table => new
                {
                    ControlCalidadAguaDetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ControlCalidadAguaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParametroId = table.Column<int>(type: "INTEGER", nullable: false),
                    Valor = table.Column<float>(type: "REAL", nullable: false),
                    Pasó = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlCalidadAguaDetalle", x => x.ControlCalidadAguaDetalleId);
                    table.ForeignKey(
                        name: "FK_ControlCalidadAguaDetalle_ControlCalidadAgua_ControlCalidadAguaId",
                        column: x => x.ControlCalidadAguaId,
                        principalTable: "ControlCalidadAgua",
                        principalColumn: "ControlCalidadAguaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControlCalidadProductoTerminado",
                columns: table => new
                {
                    ProductoTerminadoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AcciónTomada = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlCalidadProductoTerminado", x => x.ProductoTerminadoId);
                    table.ForeignKey(
                        name: "FK_ControlCalidadProductoTerminado_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParametrosEntidadesMuestreoAguas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntidadesMuestreoAguaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParametroId = table.Column<int>(type: "INTEGER", nullable: false),
                    EntidadesMuestreoAguasEntidadesMuestreoAguaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametrosEntidadesMuestreoAguas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParametrosEntidadesMuestreoAguas_EntidadesMuestreoAguas_EntidadesMuestreoAguasEntidadesMuestreoAguaId",
                        column: x => x.EntidadesMuestreoAguasEntidadesMuestreoAguaId,
                        principalTable: "EntidadesMuestreoAguas",
                        principalColumn: "EntidadesMuestreoAguaId");
                });

            migrationBuilder.CreateTable(
                name: "ProductoTerminadosDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoTerminadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParametroId = table.Column<int>(type: "INTEGER", nullable: false),
                    Valor = table.Column<float>(type: "REAL", nullable: false),
                    Pasó = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoTerminadosDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_ProductoTerminadosDetalle_ControlCalidadProductoTerminado_ProductoTerminadoId",
                        column: x => x.ProductoTerminadoId,
                        principalTable: "ControlCalidadProductoTerminado",
                        principalColumn: "ProductoTerminadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "Apellido", "Contraseña", "Email", "Nombre" },
                values: new object[,]
                {
                    { 1, "El Hage Jreij", "Cl@ve123", "abrahamehj@ams.com", "Abraham" },
                    { 2, "Pichardo Barranco", "Cl@ve123", "juliocpb@ams.com", "Julio Cesar" }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "EmpleadoId", "Apellido", "Celular", "Clave", "Dirección", "Email", "Nombre", "Teléfono" },
                values: new object[] { 1, "Almonte", "0123456789", "Cl@ve123", "Su casa", "elmontee@ams.com", "Enel", "0123456789" });

            migrationBuilder.InsertData(
                table: "EntidadesMuestreoAguas",
                columns: new[] { "EntidadesMuestreoAguaId", "Descripción" },
                values: new object[,]
                {
                    { 1, "Cisterna 1" },
                    { 2, "Cisterna 2" },
                    { 3, "Cisterna 3" },
                    { 4, "INAPA" },
                    { 5, "Filtro Carbón Activado" },
                    { 6, "Ablandadores" },
                    { 7, "Ósmosis" }
                });

            migrationBuilder.InsertData(
                table: "Parametros",
                columns: new[] { "ParametroId", "Descripción", "Máximo", "Mínimo" },
                values: new object[,]
                {
                    { 1, "Cloruro", 250f, 0f },
                    { 2, "Cloro Residual", 0f, 0f },
                    { 3, "STD", 500f, 0f },
                    { 4, "Conductancia", 700f, 0f },
                    { 5, "Dureza", 500f, 0f },
                    { 6, "PH", 8.5f, 6.5f },
                    { 7, "Sulfato", 250f, 0f },
                    { 8, "Nitrato", 10f, 0f },
                    { 9, "Hierro", 0.3f, 0f },
                    { 10, "Color", 5f, 0f },
                    { 11, "Turbidez", 0.5f, 0f },
                    { 12, "Sabor", 1f, 1f },
                    { 13, "Ozono", 0.1f, 0.05f },
                    { 14, "Lamp UV", 1f, 1f },
                    { 120, "Cloro Residual", 1.5f, 1f },
                    { 121, "Dureza", 500f, 68.4f },
                    { 122, "STD", 1000f, 70f },
                    { 123, "Color", 15f, 5f },
                    { 124, "Turbidez", 25f, 10f },
                    { 125, "Sulfato", 400f, 250f },
                    { 126, "Nitrato", 50f, 10f },
                    { 130, "Cloro Residual", 0.05f, 0f },
                    { 133, "Olor", 1f, 1f },
                    { 151, "STD", 500f, 2f }
                });

            migrationBuilder.InsertData(
                table: "ParametrosEntidadesMuestreoAguas",
                columns: new[] { "Id", "EntidadesMuestreoAguaId", "EntidadesMuestreoAguasEntidadesMuestreoAguaId", "ParametroId" },
                values: new object[,]
                {
                    { 1, 1, null, 120 },
                    { 2, 1, null, 121 },
                    { 3, 1, null, 122 },
                    { 4, 1, null, 123 },
                    { 5, 1, null, 124 },
                    { 6, 1, null, 125 },
                    { 7, 1, null, 126 },
                    { 8, 1, null, 6 },
                    { 9, 2, null, 120 },
                    { 10, 2, null, 121 },
                    { 11, 2, null, 122 },
                    { 12, 2, null, 123 },
                    { 13, 2, null, 124 },
                    { 14, 2, null, 125 },
                    { 15, 2, null, 126 },
                    { 16, 2, null, 6 },
                    { 17, 3, null, 120 },
                    { 18, 3, null, 121 },
                    { 19, 3, null, 122 },
                    { 20, 3, null, 123 },
                    { 21, 3, null, 124 },
                    { 22, 3, null, 125 },
                    { 23, 3, null, 126 },
                    { 24, 3, null, 6 },
                    { 25, 4, null, 120 },
                    { 26, 4, null, 121 },
                    { 27, 4, null, 122 },
                    { 29, 4, null, 123 },
                    { 30, 4, null, 124 },
                    { 31, 4, null, 125 },
                    { 32, 4, null, 126 },
                    { 33, 4, null, 6 },
                    { 34, 5, null, 130 },
                    { 35, 5, null, 123 },
                    { 36, 5, null, 124 },
                    { 37, 5, null, 133 },
                    { 38, 6, null, 5 },
                    { 39, 6, null, 122 },
                    { 40, 6, null, 6 },
                    { 41, 7, null, 6 },
                    { 42, 7, null, 151 }
                });

            migrationBuilder.InsertData(
                table: "Referencias",
                columns: new[] { "ReferenciaId", "Descripción", "ParametroId" },
                values: new object[,]
                {
                    { 1, "mg/L", 1 },
                    { 2, "mg/L", 2 },
                    { 3, "mg/L", 3 },
                    { 4, "CaCo3", 5 },
                    { 5, "mg/L", 7 },
                    { 6, "mg/L", 8 },
                    { 7, "mg/L", 9 },
                    { 8, "UNID", 10 },
                    { 9, "NTU", 11 },
                    { 10, "(1) Insipido y (0) Sapido", 12 },
                    { 11, "mg/L", 13 },
                    { 12, "(1) Sí y (0) no", 14 },
                    { 13, "mg/L", 120 },
                    { 14, "CaCo3", 121 },
                    { 15, "mg/L", 122 },
                    { 16, "U. Pt-Co", 123 },
                    { 17, "FTU", 124 },
                    { 18, "mg/L", 125 },
                    { 19, "mg/L", 126 },
                    { 20, "mg/L", 130 },
                    { 21, "(1) Inodoro y (0) Odoro", 133 },
                    { 22, "mg/L", 151 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ControlCalidadAguaDetalle_ControlCalidadAguaId",
                table: "ControlCalidadAguaDetalle",
                column: "ControlCalidadAguaId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlCalidadProductoTerminado_EmpleadoId",
                table: "ControlCalidadProductoTerminado",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametrosEntidadesMuestreoAguas_EntidadesMuestreoAguasEntidadesMuestreoAguaId",
                table: "ParametrosEntidadesMuestreoAguas",
                column: "EntidadesMuestreoAguasEntidadesMuestreoAguaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoTerminadosDetalle_ProductoTerminadoId",
                table: "ProductoTerminadosDetalle",
                column: "ProductoTerminadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ClienteId",
                table: "Reviews",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "ControlCalidadAguaDetalle");

            migrationBuilder.DropTable(
                name: "Parametros");

            migrationBuilder.DropTable(
                name: "ParametrosEntidadesMuestreoAguas");

            migrationBuilder.DropTable(
                name: "ProductoTerminadosDetalle");

            migrationBuilder.DropTable(
                name: "Referencias");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ControlCalidadAgua");

            migrationBuilder.DropTable(
                name: "EntidadesMuestreoAguas");

            migrationBuilder.DropTable(
                name: "ControlCalidadProductoTerminado");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
