using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AracSatis.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataAnnotationsEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YapılanIslemler",
                table: "Servislerr",
                newName: "YapilanIslemler");

            migrationBuilder.RenameColumn(
                name: "ServisGelisTarihi",
                table: "Servislerr",
                newName: "ServiseGelisTarihi");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Aracs",
                newName: "Modeli");

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Kullanicilarr",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "KullaniciAdi",
                table: "Kullanicilarr",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Kullanicilarr",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 2, 10, 18, 34, 27, 710, DateTimeKind.Local).AddTicks(3401));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YapilanIslemler",
                table: "Servislerr",
                newName: "YapılanIslemler");

            migrationBuilder.RenameColumn(
                name: "ServiseGelisTarihi",
                table: "Servislerr",
                newName: "ServisGelisTarihi");

            migrationBuilder.RenameColumn(
                name: "Modeli",
                table: "Aracs",
                newName: "Model");

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Kullanicilarr",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KullaniciAdi",
                table: "Kullanicilarr",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicilarr",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 2, 10, 16, 31, 1, 801, DateTimeKind.Local).AddTicks(4015));
        }
    }
}
