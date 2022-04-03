using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment3.Migrations
{
    public partial class AddingauthenticationtoourApiMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Items",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Items",
                newName: "Genre");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Items",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Items",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Items",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Items",
                newName: "Description");

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
