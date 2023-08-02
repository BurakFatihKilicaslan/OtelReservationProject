using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class addmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryID",
                table: "Contacts");

            migrationBuilder.AlterColumn<int>(
                name: "MessageCategoryID",
                table: "Contacts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contacts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryID",
                table: "Contacts",
                column: "MessageCategoryID",
                principalTable: "MessageCategories",
                principalColumn: "MessageCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryID",
                table: "Contacts");

            migrationBuilder.AlterColumn<int>(
                name: "MessageCategoryID",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryID",
                table: "Contacts",
                column: "MessageCategoryID",
                principalTable: "MessageCategories",
                principalColumn: "MessageCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
