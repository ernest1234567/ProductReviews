using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductReview.Server.Migrations
{
    public partial class adddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Rating" },
                values: new object[] { new DateTime(2021, 11, 7, 14, 33, 10, 966, DateTimeKind.Local).AddTicks(6747), new DateTime(2021, 11, 7, 14, 33, 10, 968, DateTimeKind.Local).AddTicks(9278), "4star" });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 7, 14, 33, 10, 970, DateTimeKind.Local).AddTicks(2374), new DateTime(2021, 11, 7, 14, 33, 10, 970, DateTimeKind.Local).AddTicks(2386) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Rating" },
                values: new object[] { new DateTime(2021, 10, 24, 15, 56, 29, 451, DateTimeKind.Local).AddTicks(9152), new DateTime(2021, 10, 24, 15, 56, 29, 454, DateTimeKind.Local).AddTicks(2199), null });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 24, 15, 56, 29, 456, DateTimeKind.Local).AddTicks(1274), new DateTime(2021, 10, 24, 15, 56, 29, 456, DateTimeKind.Local).AddTicks(1288) });
        }
    }
}
