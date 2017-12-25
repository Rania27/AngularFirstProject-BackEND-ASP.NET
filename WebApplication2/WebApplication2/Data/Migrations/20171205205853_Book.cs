using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication2.Data.Migrations
{
    public partial class Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "starRating",
                table: "Book",
                nullable: false,
                oldClrType: typeof(float),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "Book",
                nullable: false,
                oldClrType: typeof(float),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "imageUrl",
                table: "Book",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "starRating",
                table: "Book",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "price",
                table: "Book",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "imageUrl",
                table: "Book",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
