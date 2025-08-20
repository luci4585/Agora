using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Capacitaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Detalle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ponente = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Cupo = table.Column<int>(type: "int", nullable: false),
                    InscripcionAbierta = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacitaciones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoInscripciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoInscripciones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposInscripcionesCapacitaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CapacitacionId = table.Column<int>(type: "int", nullable: false),
                    TipoInscripcionId = table.Column<int>(type: "int", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposInscripcionesCapacitaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposInscripcionesCapacitaciones_Capacitaciones_Capacitacion~",
                        column: x => x.CapacitacionId,
                        principalTable: "Capacitaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TiposInscripcionesCapacitaciones_TipoInscripciones_TipoInscr~",
                        column: x => x.TipoInscripcionId,
                        principalTable: "TipoInscripciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inscripciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dni = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoInscripcionId = table.Column<int>(type: "int", nullable: false),
                    CapacitacionId = table.Column<int>(type: "int", nullable: false),
                    Acreditado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Importe = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Pagado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UsuarioCobroId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Capacitaciones_CapacitacionId",
                        column: x => x.CapacitacionId,
                        principalTable: "Capacitaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscripciones_TipoInscripciones_TipoInscripcionId",
                        column: x => x.TipoInscripcionId,
                        principalTable: "TipoInscripciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Usuarios_UsuarioCobroId",
                        column: x => x.UsuarioCobroId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Capacitaciones",
                columns: new[] { "Id", "Cupo", "Detalle", "FechaHora", "InscripcionAbierta", "IsDeleted", "Nombre", "Ponente" },
                values: new object[,]
                {
                    { 1, 30, "Aprende los conceptos básicos de programación.", new DateTime(2025, 8, 29, 18, 34, 10, 925, DateTimeKind.Local).AddTicks(4901), true, false, "Introducción a la Programación", "Carlos Gómez" },
                    { 2, 25, "Crea aplicaciones web modernas con ASP.NET Core.", new DateTime(2025, 9, 8, 18, 34, 10, 925, DateTimeKind.Local).AddTicks(4960), true, false, "Desarrollo Web con ASP.NET Core", "Ana Martínez" }
                });

            migrationBuilder.InsertData(
                table: "TipoInscripciones",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Público en general" },
                    { 2, false, "Docentes" },
                    { 3, false, "Estudiantes" },
                    { 4, false, "Jubilados" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DeleteDate", "Email", "IsDeleted", "Nombre", "Password", "TipoUsuario" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Administrador", "admin123", 2 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Usuario", "user123", 0 }
                });

            migrationBuilder.InsertData(
                table: "Inscripciones",
                columns: new[] { "Id", "Acreditado", "Apellido", "CapacitacionId", "Dni", "Email", "Importe", "IsDeleted", "Nombre", "Pagado", "TipoInscripcionId", "UsuarioCobroId" },
                values: new object[,]
                {
                    { 1, false, "Pérez", 1, "12345678", "perezjuan@gmail.com", 10000m, false, "Juan", false, 1, null },
                    { 2, false, "Gómez", 2, "87654321", "gomezana@gmail.com", 8000m, false, "Ana", false, 2, null },
                    { 3, false, "Lopez", 1, "12345678", "lopezmaria@gmail.com", 5000m, false, "Maria", false, 3, null }
                });

            migrationBuilder.InsertData(
                table: "TiposInscripcionesCapacitaciones",
                columns: new[] { "Id", "CapacitacionId", "Costo", "IsDeleted", "TipoInscripcionId" },
                values: new object[,]
                {
                    { 1, 1, 10000m, false, 1 },
                    { 2, 1, 8000m, false, 2 },
                    { 3, 2, 5000m, false, 3 },
                    { 4, 2, 3000m, false, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_CapacitacionId",
                table: "Inscripciones",
                column: "CapacitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_TipoInscripcionId",
                table: "Inscripciones",
                column: "TipoInscripcionId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_UsuarioCobroId",
                table: "Inscripciones",
                column: "UsuarioCobroId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposInscripcionesCapacitaciones_CapacitacionId",
                table: "TiposInscripcionesCapacitaciones",
                column: "CapacitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposInscripcionesCapacitaciones_TipoInscripcionId",
                table: "TiposInscripcionesCapacitaciones",
                column: "TipoInscripcionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscripciones");

            migrationBuilder.DropTable(
                name: "TiposInscripcionesCapacitaciones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Capacitaciones");

            migrationBuilder.DropTable(
                name: "TipoInscripciones");
        }
    }
}
