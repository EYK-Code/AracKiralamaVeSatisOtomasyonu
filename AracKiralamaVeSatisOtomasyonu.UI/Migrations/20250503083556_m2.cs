using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AracKiralamaVeSatisOtomasyonu.UI.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arac_Kategori_KategoriId",
                table: "Arac");

            migrationBuilder.DropForeignKey(
                name: "FK_Kiralama_Arac_AracId",
                table: "Kiralama");

            migrationBuilder.DropForeignKey(
                name: "FK_Kiralama_Musteri_MusteriId",
                table: "Kiralama");

            migrationBuilder.DropForeignKey(
                name: "FK_Satis_Arac_AracId",
                table: "Satis");

            migrationBuilder.DropForeignKey(
                name: "FK_Satis_Musteri_MusteriId",
                table: "Satis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Satis",
                table: "Satis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musteri",
                table: "Musteri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kiralama",
                table: "Kiralama");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arac",
                table: "Arac");

            migrationBuilder.RenameTable(
                name: "Satis",
                newName: "Satislar");

            migrationBuilder.RenameTable(
                name: "Musteri",
                newName: "Musteriler");

            migrationBuilder.RenameTable(
                name: "Kiralama",
                newName: "Kiralamalar");

            migrationBuilder.RenameTable(
                name: "Kategori",
                newName: "Kategoriler");

            migrationBuilder.RenameTable(
                name: "Arac",
                newName: "Araclar");

            migrationBuilder.RenameIndex(
                name: "IX_Satis_MusteriId",
                table: "Satislar",
                newName: "IX_Satislar_MusteriId");

            migrationBuilder.RenameIndex(
                name: "IX_Satis_AracId",
                table: "Satislar",
                newName: "IX_Satislar_AracId");

            migrationBuilder.RenameIndex(
                name: "IX_Kiralama_MusteriId",
                table: "Kiralamalar",
                newName: "IX_Kiralamalar_MusteriId");

            migrationBuilder.RenameIndex(
                name: "IX_Kiralama_AracId",
                table: "Kiralamalar",
                newName: "IX_Kiralamalar_AracId");

            migrationBuilder.RenameIndex(
                name: "IX_Arac_KategoriId",
                table: "Araclar",
                newName: "IX_Araclar_KategoriId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SatisTarihi",
                table: "Satislar",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<decimal>(
                name: "SatisFiyati",
                table: "Satislar",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "OdemeTipi",
                table: "Satislar",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Musteriler",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Musteriler",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "Musteriler",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AdSoyad",
                table: "Musteriler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "GunlukUcret",
                table: "Kiralamalar",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BitisTarihi",
                table: "Kiralamalar",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BaslangicTarihi",
                table: "Kiralamalar",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "KategoriAdi",
                table: "Kategoriler",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "YakitTuru",
                table: "Araclar",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SanzimanTipi",
                table: "Araclar",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Renk",
                table: "Araclar",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Araclar",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MevcutDurum",
                table: "Araclar",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Marka",
                table: "Araclar",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Durum",
                table: "Araclar",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Satislar",
                table: "Satislar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musteriler",
                table: "Musteriler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kiralamalar",
                table: "Kiralamalar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategoriler",
                table: "Kategoriler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Araclar",
                table: "Araclar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Araclar_Kategoriler_KategoriId",
                table: "Araclar",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kiralamalar_Araclar_AracId",
                table: "Kiralamalar",
                column: "AracId",
                principalTable: "Araclar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kiralamalar_Musteriler_MusteriId",
                table: "Kiralamalar",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Satislar_Araclar_AracId",
                table: "Satislar",
                column: "AracId",
                principalTable: "Araclar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Satislar_Musteriler_MusteriId",
                table: "Satislar",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Araclar_Kategoriler_KategoriId",
                table: "Araclar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kiralamalar_Araclar_AracId",
                table: "Kiralamalar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kiralamalar_Musteriler_MusteriId",
                table: "Kiralamalar");

            migrationBuilder.DropForeignKey(
                name: "FK_Satislar_Araclar_AracId",
                table: "Satislar");

            migrationBuilder.DropForeignKey(
                name: "FK_Satislar_Musteriler_MusteriId",
                table: "Satislar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Satislar",
                table: "Satislar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musteriler",
                table: "Musteriler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kiralamalar",
                table: "Kiralamalar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategoriler",
                table: "Kategoriler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Araclar",
                table: "Araclar");

            migrationBuilder.RenameTable(
                name: "Satislar",
                newName: "Satis");

            migrationBuilder.RenameTable(
                name: "Musteriler",
                newName: "Musteri");

            migrationBuilder.RenameTable(
                name: "Kiralamalar",
                newName: "Kiralama");

            migrationBuilder.RenameTable(
                name: "Kategoriler",
                newName: "Kategori");

            migrationBuilder.RenameTable(
                name: "Araclar",
                newName: "Arac");

            migrationBuilder.RenameIndex(
                name: "IX_Satislar_MusteriId",
                table: "Satis",
                newName: "IX_Satis_MusteriId");

            migrationBuilder.RenameIndex(
                name: "IX_Satislar_AracId",
                table: "Satis",
                newName: "IX_Satis_AracId");

            migrationBuilder.RenameIndex(
                name: "IX_Kiralamalar_MusteriId",
                table: "Kiralama",
                newName: "IX_Kiralama_MusteriId");

            migrationBuilder.RenameIndex(
                name: "IX_Kiralamalar_AracId",
                table: "Kiralama",
                newName: "IX_Kiralama_AracId");

            migrationBuilder.RenameIndex(
                name: "IX_Araclar_KategoriId",
                table: "Arac",
                newName: "IX_Arac_KategoriId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SatisTarihi",
                table: "Satis",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<decimal>(
                name: "SatisFiyati",
                table: "Satis",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "OdemeTipi",
                table: "Satis",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "AdSoyad",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "GunlukUcret",
                table: "Kiralama",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BitisTarihi",
                table: "Kiralama",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BaslangicTarihi",
                table: "Kiralama",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "KategoriAdi",
                table: "Kategori",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "YakitTuru",
                table: "Arac",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "SanzimanTipi",
                table: "Arac",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Renk",
                table: "Arac",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Arac",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "MevcutDurum",
                table: "Arac",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Marka",
                table: "Arac",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Durum",
                table: "Arac",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Satis",
                table: "Satis",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musteri",
                table: "Musteri",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kiralama",
                table: "Kiralama",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategori",
                table: "Kategori",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arac",
                table: "Arac",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Arac_Kategori_KategoriId",
                table: "Arac",
                column: "KategoriId",
                principalTable: "Kategori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kiralama_Arac_AracId",
                table: "Kiralama",
                column: "AracId",
                principalTable: "Arac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kiralama_Musteri_MusteriId",
                table: "Kiralama",
                column: "MusteriId",
                principalTable: "Musteri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Satis_Arac_AracId",
                table: "Satis",
                column: "AracId",
                principalTable: "Arac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Satis_Musteri_MusteriId",
                table: "Satis",
                column: "MusteriId",
                principalTable: "Musteri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
