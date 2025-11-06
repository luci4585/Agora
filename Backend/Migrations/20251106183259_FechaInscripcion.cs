using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class FechaInscripcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInscripcion",
                table: "Inscripciones",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 11, 16, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2025, 11, 26, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaHora",
                value: new DateTime(2025, 11, 21, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaHora",
                value: new DateTime(2025, 12, 1, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 32, 55, 634, DateTimeKind.Local).AddTicks(2746));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaInscripcion",
                table: "Inscripciones");

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 10, 12, 17, 23, 24, 281, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2025, 10, 22, 17, 23, 24, 281, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaHora",
                value: new DateTime(2025, 10, 17, 17, 23, 24, 281, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaHora",
                value: new DateTime(2025, 10, 27, 17, 23, 24, 281, DateTimeKind.Local).AddTicks(6831));
        }
    }
}
