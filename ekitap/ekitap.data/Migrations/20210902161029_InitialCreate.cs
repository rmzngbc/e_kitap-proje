using Microsoft.EntityFrameworkCore.Migrations;

namespace ekitap.data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategoriler",
                columns: table => new
                {
                    kategoriId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ka_adi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategoriler", x => x.kategoriId);
                });

            migrationBuilder.CreateTable(
                name: "kitaplar",
                columns: table => new
                {
                    kitapId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    k_adi = table.Column<string>(nullable: true),
                    k_fiyat = table.Column<double>(nullable: true),
                    k_sayfa = table.Column<int>(nullable: false),
                    k_aciklama = table.Column<string>(nullable: true),
                    k_resim = table.Column<string>(nullable: true),
                    k_onay = table.Column<bool>(nullable: false),
                    kategoriId = table.Column<int>(nullable: false)
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_kitaplar_kategoriId",
                table: "kitaplar",
                column: "kategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kitaplar");

            migrationBuilder.DropTable(
                name: "kategoriler");
        }
    }
}
