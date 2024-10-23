using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhehelloSemoko_ST10163295_PROG6212_POE.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LSurname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LStart = table.Column<DateOnly>(type: "date", nullable: false),
                    LEnd = table.Column<DateOnly>(type: "date", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claims");
        }
    }
}
