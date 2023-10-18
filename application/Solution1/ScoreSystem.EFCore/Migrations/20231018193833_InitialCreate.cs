using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScoreSystem.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScoreRecords",
                columns: table => new
                {
                    RecordId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Suite = table.Column<string>(type: "TEXT", nullable: false),
                    Passed = table.Column<int>(type: "INTEGER", nullable: false),
                    Failed = table.Column<int>(type: "INTEGER", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreRecords", x => new { x.RecordId, x.Suite });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScoreRecords");
        }
    }
}
