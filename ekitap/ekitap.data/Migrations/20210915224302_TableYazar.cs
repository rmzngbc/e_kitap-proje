using Microsoft.EntityFrameworkCore.Migrations;

namespace ekitap.data.Migrations
{
    public partial class TableYazar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_kitapyazar_kitapId",
                table: "kitapyazar",
                column: "kitapId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kitapyazar");

            migrationBuilder.DropTable(
                name: "yazarlar");
        }
    }
}
