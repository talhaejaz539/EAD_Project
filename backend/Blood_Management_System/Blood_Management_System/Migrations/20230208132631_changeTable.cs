using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class changeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fileName",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BloodRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "BloodRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserAdd",
                table: "BloodRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserDel",
                table: "BloodRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserMod",
                table: "BloodRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "BloodRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fileName",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BloodRequests");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "BloodRequests");

            migrationBuilder.DropColumn(
                name: "UserAdd",
                table: "BloodRequests");

            migrationBuilder.DropColumn(
                name: "UserDel",
                table: "BloodRequests");

            migrationBuilder.DropColumn(
                name: "UserMod",
                table: "BloodRequests");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "BloodRequests");
        }
    }
}
