using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AnswearAndSubCategoryInheritsBaseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "SubCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Answears",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Answears",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Answears");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Answears");
        }
    }
}
