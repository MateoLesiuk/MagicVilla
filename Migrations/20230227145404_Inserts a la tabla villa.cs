using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class Insertsalatablavilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "Pileta y Guardia", "Hermosa Villa con Vista al Lago", new DateTime(2023, 2, 27, 11, 54, 4, 867, DateTimeKind.Local).AddTicks(4850), new DateTime(2023, 2, 27, 11, 54, 4, 867, DateTimeKind.Local).AddTicks(4839), "", 5, "Villa Real", 5, "200" },
                    { 2, "Restaurante bar, Equitación", "Señoral y Placentera", new DateTime(2023, 2, 27, 11, 54, 4, 867, DateTimeKind.Local).AddTicks(4853), new DateTime(2023, 2, 27, 11, 54, 4, 867, DateTimeKind.Local).AddTicks(4853), "", 5, "Villa Rosada", 5, "500" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
