using Microsoft.EntityFrameworkCore.Migrations;

namespace ekitap.data.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategoriler",
                columns: table => new
                {
                    kategoriId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ka_adi = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategoriler", x => x.kategoriId);
                });

            migrationBuilder.CreateTable(
                name: "yayinevleri",
                columns: table => new
                {
                    yayineviId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    yayineviAd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yayinevleri", x => x.yayineviId);
                });

            migrationBuilder.CreateTable(
                name: "yazarlar",
                columns: table => new
                {
                    yazarId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    yazarad = table.Column<string>(nullable: true),
                    yazarsoyad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yazarlar", x => x.yazarId);
                });

            migrationBuilder.CreateTable(
                name: "kitaplar",
                columns: table => new
                {
                    kitapId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    k_adi = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    k_fiyat = table.Column<double>(nullable: true),
                    k_sayfa = table.Column<int>(nullable: false),
                    k_aciklama = table.Column<string>(nullable: true),
                    k_resim = table.Column<string>(nullable: true),
                    k_onay = table.Column<bool>(nullable: false),
                    kategoriId = table.Column<int>(nullable: false),
                    k_anasayfa = table.Column<bool>(nullable: false),
                    yayineviId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitaplar", x => x.kitapId);
                    table.ForeignKey(
                        name: "FK_kitaplar_kategoriler_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoriler",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kitaplar_yayinevleri_yayineviId",
                        column: x => x.yayineviId,
                        principalTable: "yayinevleri",
                        principalColumn: "yayineviId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "kitapyazar",
                columns: table => new
                {
                    yazarId = table.Column<int>(nullable: false),
                    kitapId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitapyazar", x => new { x.yazarId, x.kitapId });
                    table.ForeignKey(
                        name: "FK_kitapyazar_kitaplar_kitapId",
                        column: x => x.kitapId,
                        principalTable: "kitaplar",
                        principalColumn: "kitapId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_kitapyazar_yazarlar_yazarId",
                        column: x => x.yazarId,
                        principalTable: "yazarlar",
                        principalColumn: "yazarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kitaplar_kategoriId",
                table: "kitaplar",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_kitaplar_yayineviId",
                table: "kitaplar",
                column: "yayineviId");

            migrationBuilder.CreateIndex(
                name: "IX_kitapyazar_kitapId",
                table: "kitapyazar",
                column: "kitapId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kitapyazar");

            migrationBuilder.DropTable(
                name: "kitaplar");

            migrationBuilder.DropTable(
                name: "yazarlar");

            migrationBuilder.DropTable(
                name: "kategoriler");

            migrationBuilder.DropTable(
                name: "yayinevleri");
        }
    }
}
