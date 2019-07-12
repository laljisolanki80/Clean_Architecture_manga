﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Manga.Infrastructure.EntityFrameworkDataAccess.Migrations
{
    public partial class AddSSN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Credit",
                keyColumn: "Id",
                keyValue: new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 11, 12, 55, 11, 934, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Debit",
                keyColumn: "Id",
                keyValue: new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 11, 12, 55, 11, 934, DateTimeKind.Utc).AddTicks(2653));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Credit",
                keyColumn: "Id",
                keyValue: new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 9, 10, 44, 37, 283, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Debit",
                keyColumn: "Id",
                keyValue: new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                column: "TransactionDate",
                value: new DateTime(2019, 7, 9, 10, 44, 37, 284, DateTimeKind.Utc).AddTicks(2675));
        }
    }
}