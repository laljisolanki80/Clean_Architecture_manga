using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manga.Infrastructure.EntityFrameworkDataAccess.Migrations
{
    public partial class NewUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Credit",
                keyColumn: "Id",
                keyValue: new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 14, 12, 3, 30, 942, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Debit",
                keyColumn: "Id",
                keyValue: new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 14, 12, 3, 30, 942, DateTimeKind.Utc).AddTicks(4551));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SSN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Credit",
                keyColumn: "Id",
                keyValue: new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 12, 9, 45, 20, 553, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name", "SSN" },
                values: new object[] { new Guid("197d0438-e04b-453d-b5de-eca05960c6ae"), "Test User", "19860817-9999" });

            migrationBuilder.UpdateData(
                table: "Debit",
                keyColumn: "Id",
                keyValue: new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 12, 9, 45, 20, 554, DateTimeKind.Utc).AddTicks(2290));
        }
    }
}
