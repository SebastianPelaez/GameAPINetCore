﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameAPICore.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblGames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Round = table.Column<int>(nullable: false),
                    PlayerOneName = table.Column<string>(maxLength: 50, nullable: true),
                    PlayerOneOption = table.Column<int>(nullable: false),
                    PlayerTwoName = table.Column<string>(maxLength: 50, nullable: true),
                    PlayerTwoOption = table.Column<int>(nullable: false),
                    Winner = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGames", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblGames");
        }
    }
}
