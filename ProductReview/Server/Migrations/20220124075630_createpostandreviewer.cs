using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductReview.Server.Migrations
{
    public partial class createpostandreviewer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 24, 15, 56, 29, 451, DateTimeKind.Local).AddTicks(9152), new DateTime(2021, 10, 24, 15, 56, 29, 454, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 24, 15, 56, 29, 456, DateTimeKind.Local).AddTicks(1274), new DateTime(2021, 10, 24, 15, 56, 29, 456, DateTimeKind.Local).AddTicks(1288) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 17, 16, 53, 31, 2, DateTimeKind.Local).AddTicks(6917), new DateTime(2021, 10, 17, 16, 53, 31, 4, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 17, 16, 53, 31, 6, DateTimeKind.Local).AddTicks(4531), new DateTime(2021, 10, 17, 16, 53, 31, 6, DateTimeKind.Local).AddTicks(4546) });
        }
    }
}
