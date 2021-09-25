﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ekitap.data.Migrations
{
    public partial class addkitapUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "kitaplar",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "kitaplar");
        }
    }
}