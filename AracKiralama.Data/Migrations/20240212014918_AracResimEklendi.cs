using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AracSatis.Data.Migrations
{
    /// <inheritdoc />
    public partial class AracResimEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resim1",
                table: "Aracs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim2",
                table: "Aracs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim3",
                table: "Aracs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicilarr",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 2, 12, 4, 49, 17, 800, DateTimeKind.Local).AddTicks(8553));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resim1",
                table: "Aracs");

            migrationBuilder.DropColumn(
                name: "Resim2",
                table: "Aracs");

            migrationBuilder.DropColumn(
                name: "Resim3",
                table: "Aracs");

            migrationBuilder.UpdateData(
                table: "Kullanicilarr",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 2, 10, 18, 34, 27, 710, DateTimeKind.Local).AddTicks(3401));
        }
    }
}
