using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductReview.Server.Migrations
{
    public partial class reviewerid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 8, 23, 40, 58, 729, DateTimeKind.Local).AddTicks(518), new DateTime(2021, 11, 8, 23, 40, 58, 731, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 8, 23, 40, 58, 733, DateTimeKind.Local).AddTicks(1916), new DateTime(2021, 11, 8, 23, 40, 58, 733, DateTimeKind.Local).AddTicks(1938) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 7, 14, 33, 10, 966, DateTimeKind.Local).AddTicks(6747), new DateTime(2021, 11, 7, 14, 33, 10, 968, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 7, 14, 33, 10, 970, DateTimeKind.Local).AddTicks(2374), new DateTime(2021, 11, 7, 14, 33, 10, 970, DateTimeKind.Local).AddTicks(2386) });
        }
    }
}
