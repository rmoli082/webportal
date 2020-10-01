using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeCard.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PunchEvent",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeCode = table.Column<int>(nullable: false),
                    PunchType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PunchEvent", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TimeCard",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    PunchType = table.Column<string>(nullable: true),
                    TimeCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeCard", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PunchEvent");

            migrationBuilder.DropTable(
                name: "TimeCard");
        }
    }
}
