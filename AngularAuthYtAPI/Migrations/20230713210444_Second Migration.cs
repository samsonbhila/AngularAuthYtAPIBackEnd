using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularAuthYtAPI.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "natural_gases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "DateTime", nullable: true),
                    price = table.Column<long>(type: "number", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_natural_gases", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "natural_gases");
        }
    }
}
