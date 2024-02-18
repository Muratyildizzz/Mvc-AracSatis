using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AracSatis.Data.Migrations
{
    /// <inheritdoc />
    public partial class AnaSayfaEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Anasayfa",
                table: "Aracs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Kullanicilarr",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 2, 14, 4, 46, 26, 273, DateTimeKind.Local).AddTicks(9659));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anasayfa",
                table: "Aracs");

            migrationBuilder.UpdateData(
                table: "Kullanicilarr",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 2, 14, 4, 44, 57, 455, DateTimeKind.Local).AddTicks(198));
        }
    }
}
