using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class correccionInscripcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Inscripciones");

            migrationBuilder.DropColumn(
                name: "Dni",
                table: "Inscripciones");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Inscripciones");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Inscripciones");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "Dni");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Usuarios",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Inscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 10, 12, 17, 7, 22, 102, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Detalle", "FechaHora" },
                values: new object[] { "Crea webapps modernas con ASP.NET Core.", new DateTime(2025, 10, 22, 17, 7, 22, 102, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.InsertData(
                table: "Capacitaciones",
                columns: new[] { "Id", "Cupo", "Detalle", "FechaHora", "InscripcionAbierta", "IsDeleted", "Nombre", "Ponente" },
                values: new object[,]
                {
                    { 3, 20, "Aprende a manejar bases de datos con SQL.", new DateTime(2025, 10, 17, 17, 7, 22, 102, DateTimeKind.Local).AddTicks(1356), true, false, "Curso SQL", "Luis Pérez" },
                    { 4, 30, "Domina JavaScript para desarrollo web.", new DateTime(2025, 10, 27, 17, 7, 22, 102, DateTimeKind.Local).AddTicks(1359), true, false, "Taller de JavaScript", "Marta López" }
                });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Importe", "UsuarioId" },
                values: new object[] { 15000m, 2 });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Acreditado", "Importe", "TipoInscripcionId", "UsuarioId" },
                values: new object[] { true, 0m, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CapacitacionId", "Importe", "TipoInscripcionId", "UsuarioId" },
                values: new object[] { 3, 0m, 2, 4 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellido", "DeleteDate", "Dni", "Email", "IsDeleted", "Nombre", "TipoUsuario" },
                values: new object[,]
                {
                    { 3, "Rodríguez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "37222333", "carlos.rodriguez@example.com", false, "Carlos", 1 },
                    { 4, "Fernández", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "42111111", "lucia.fernandez@example.com", false, "Lucía", 0 }
                });

            migrationBuilder.InsertData(
                table: "Inscripciones",
                columns: new[] { "Id", "Acreditado", "CapacitacionId", "Importe", "IsDeleted", "Pagado", "TipoInscripcionId", "UsuarioCobroId", "UsuarioId" },
                values: new object[] { 4, true, 4, 12000m, false, false, 1, null, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_UsuarioId",
                table: "Inscripciones",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripciones_Usuarios_UsuarioId",
                table: "Inscripciones",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscripciones_Usuarios_UsuarioId",
                table: "Inscripciones");

            migrationBuilder.DropIndex(
                name: "IX_Inscripciones_UsuarioId",
                table: "Inscripciones");

            migrationBuilder.DeleteData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Inscripciones");

            migrationBuilder.RenameColumn(
                name: "Dni",
                table: "Usuarios",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Inscripciones",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Dni",
                table: "Inscripciones",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Inscripciones",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Inscripciones",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 8, 29, 18, 34, 10, 925, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Detalle", "FechaHora" },
                values: new object[] { "Crea aplicaciones web modernas con ASP.NET Core.", new DateTime(2025, 9, 8, 18, 34, 10, 925, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Apellido", "Dni", "Email", "Importe", "Nombre" },
                values: new object[] { "Pérez", "12345678", "perezjuan@gmail.com", 10000m, "Juan" });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Acreditado", "Apellido", "Dni", "Email", "Importe", "Nombre", "TipoInscripcionId" },
                values: new object[] { false, "Gómez", "87654321", "gomezana@gmail.com", 8000m, "Ana", 2 });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Apellido", "CapacitacionId", "Dni", "Email", "Importe", "Nombre", "TipoInscripcionId" },
                values: new object[] { "Lopez", 1, "12345678", "lopezmaria@gmail.com", 5000m, "Maria", 3 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DeleteDate", "Email", "IsDeleted", "Nombre", "Password", "TipoUsuario" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "Administrador", "admin123", 2 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", false, "Usuario", "user123", 0 }
                });
        }
    }
}
