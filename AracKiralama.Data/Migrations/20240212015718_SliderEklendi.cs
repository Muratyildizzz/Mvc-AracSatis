using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AracSatis.Data.Migrations
{
    /// <inheritdoc />
    public partial class SliderEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliderlerr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslık = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Acıklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliderlerr", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Kullanicilarr",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 2, 12, 4, 57, 17, 910, DateTimeKind.Local).AddTicks(3896));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliderlerr");

            migrationBuilder.UpdateData(
                table: "Kullanicilarr",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 2, 12, 4, 49, 17, 800, DateTimeKind.Local).AddTicks(8553));
        }
    }
}
