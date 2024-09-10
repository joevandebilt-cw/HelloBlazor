using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BethanysPieShop.HRM.Migrations
{
    /// <inheritdoc />
    public partial class StoreImageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageContent",
                table: "Employees",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "ImageContent",
                value: null);

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 5, 43, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 5, 13, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 7, 29, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 0, 23, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 21, 48, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 19, 57, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 12, 49, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 9, 35, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 17, 30, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 22, 35, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 19, 15, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 13, 6, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 8, 58, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 21, 12, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 12, 28, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 3, 33, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 6, 6, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 13, 12, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 11, 10, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 21, 14, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 2, 2, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 11, 40, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 8, 45, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 18, 25, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 14, 57, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 5, 24, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 4, 59, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 6, 20, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 7, 2, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 2, 40, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 27, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 13, 17, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 22, 16, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 3, 30, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 22, 51, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 0, 19, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 13, 12, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 9, 35, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 35, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 22, 53, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 12, 24, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 8, 9, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 3, 37, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 12, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 46, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 15, 35, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 0, 8, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 6, 31, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 13, 54, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 16, 29, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 18, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 11, 0, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 23, 21, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 10, 22, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 8, 33, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 3, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 5, 22, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 17, 59, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 9, 32, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 6, 32, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 23, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 19, 40, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 19, 1, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 21, 18, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 4, 45, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 13, 9, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 5, 49, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 21, 27, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 16, 48, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 21, 32, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 17, 47, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 19, 12, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 15, 41, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 2, 0, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 22, 46, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 0, 23, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 11, 28, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 17, 35, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 18, 31, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 12, 34, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 4, 3, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 10, 31, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 11, 28, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 22, 31, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 8, 0, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 6, 52, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 8, 56, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 14, 15, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 18, 21, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 7, 8, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 19, 8, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 4, 18, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 4, 30, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 12, 18, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 3, 41, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 8, 18, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 12, 1, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 20, 4, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 3, 16, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 3, 11, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 16, 15, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 21, 27, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 15, 26, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 5, 40, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 5, 53, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 16, 35, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 18, 46, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 10, 1, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 23, 13, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 22, 39, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 34, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 21, 17, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 11, 40, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 6, 23, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 12, 54, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 5, 15, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 15, 44, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 15, 30, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 11, 55, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 3, 49, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 1, 54, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 18, 24, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 23, 46, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 8, 55, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 11, 39, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 9, 35, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 21, 48, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 11, 0, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 18, 48, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 20, 58, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 11, 40, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 8, 34, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 0, 18, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 21, 37, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 1, 34, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 4, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 21, 47, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 12, 52, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 8, 23, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 16, 6, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 55, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 3, 46, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 11, 51, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 10, 19, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 13, 51, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 20, 43, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 21, 38, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 16, 41, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 1, 57, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 15, 18, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 19, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 22, 48, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 42, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 12, 9, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 9, 14, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 13, 14, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 20, 51, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 0, 30, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 13, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 16, 57, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 22, 32, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 3, 44, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 6, 53, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 7, 0, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 43, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 14, 53, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 5, 1, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 3, 30, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 10, 48, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 14, 9, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 22, 24, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 11, 22, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 22, 45, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 11, 19, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 23, 52, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 23, 49, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 1, 33, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 0, 5, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 13, 19, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 11, 32, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 2, 17, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 6, 55, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 9, 20, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 8, 44, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 20, 2, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 6, 18, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 11, 0, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 14, 30, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 35, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 16, 14, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 4, 45, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 22, 8, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 12, 57, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 10, 24, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 11, 34, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 7, 31, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 17, 12, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 11, 52, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 21, 5, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 1, 52, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 0, 13, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 1, 15, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 18, 26, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 7, 18, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 18, 50, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 5, 12, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 22, 45, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 8, 33, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 8, 15, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 8, 36, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 5, 52, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 8, 7, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 20, 34, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 12, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 12, 52, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 9, 11, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 9, 44, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 6, 26, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 7, 38, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 18, 3, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 7, 47, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 17, 11, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 20, 50, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 3, 40, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 22, 47, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 14, 11, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 10, 17, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 8, 58, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 18, 32, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 9, 29, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 5, 33, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 12, 33, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 11, 11, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 16, 30, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 15, 24, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 19, 51, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 19, 21, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 18, 17, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 16, 33, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 18, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 1, 29, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 4, 18, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 2, 29, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 22, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 16, 37, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 0, 22, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 23, 19, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 13, 32, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 9, 27, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 13, 0, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 0, 52, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 3, 21, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 16, 52, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 2, 35, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 0, 54, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 2, 52, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 17, 27, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 20, 21, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 21, 21, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 1, 51, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 11, 18, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 17, 58, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 9, 11, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 11, 23, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 5, 24, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 18, 47, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 1, 27, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 4, 32, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 0, 1, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 20, 12, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 18, 26, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 5, 10, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 9, 41, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 7, 49, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 15, 18, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 15, 54, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 23, 16, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 21, 33, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 21, 45, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 22, 39, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 4, 57, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 2, 14, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 7, 2, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 0, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 9, 37, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 2, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 16, 9, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 1, 23, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 11, 10, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 7, 57, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 2, 28, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 55, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 11, 20, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 8, 40, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 23, 5, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 55, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 18, 7, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 5, 6, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 3, 32, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 4, 8, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 18, 4, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 12, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 1, 33, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 17, 47, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 5, 17, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 1, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 14, 26, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 3, 59, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 15, 10, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 13, 41, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 23, 48, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 2, 27, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 11, 29, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 5, 25, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 18, 3, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 16, 51, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 14, 46, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 1, 15, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 11, 16, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 5, 54, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 10, 0, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 6, 6, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 21, 31, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 5, 8, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 5, 7, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 18, 39, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 11, 6, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 3, 23, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 6, 36, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 7, 42, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 13, 53, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 18, 38, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 18, 48, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 33, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 1, 42, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 10, 34, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 4, 25, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 11, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 4, 3, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 23, 34, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 13, 16, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 15, 35, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 13, 57, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 13, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 7, 43, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 17, 38, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 1, 38, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 19, 12, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 10, 15, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 3, 16, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 16, 0, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 1, 42, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 18, 44, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 11, 39, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 14, 58, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 3, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 10, 29, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 5, 49, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 16, 30, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 1, 18, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 17, 41, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 22, 30, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 18, 18, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 21, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 17, 53, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 27, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 20, 9, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 43, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 5, 8, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 11, 4, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 10, 32, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 6, 41, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 9, 22, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 14, 17, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 8, 44, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 19, 44, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 41, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 2, 55, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 23, 21, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 191,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 23, 58, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 5, 36, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 11, 25, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 17, 25, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 5, 5, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 3, 46, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 6, 43, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 12, 3, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 11, 1, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 6, 56, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 18, 39, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 12, 45, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 50, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 2, 24, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 18, 4, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 21, 21, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 9, 58, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 11, 14, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 3, 10, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 8, 35, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 23, 54, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 12, 51, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 23, 37, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 11, 16, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 11, 9, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 4, 41, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 21, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 14, 36, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 9, 14, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 11, 13, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 5, 28, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 3, 8, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 5, 49, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 21, 29, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 20, 45, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 2, 37, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 9, 11, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 15, 27, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 7, 19, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 13, 57, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 7, 3, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 15, 58, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 4, 37, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 1, 13, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 11, 21, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 16, 0, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 23, 25, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 4, 11, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 2, 52, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 3, 53, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 23, 5, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 6, 1, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 4, 49, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 20, 4, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 19, 27, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 20, 5, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 45, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 1, 20, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 4, 47, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 15, 41, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 7, 44, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 12, 37, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 6, 51, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 14, 27, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 7, 35, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 21, 48, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 3, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 5, 18, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 12, 20, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 15, 46, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 0, 13, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 8, 32, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 2, 11, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 3, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 228,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 1, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 39, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 6, 21, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 19, 8, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 3, 22, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 6, 26, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 16, 24, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 14, 32, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 21, 41, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 11, 15, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 4, 27, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 17, 42, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 3, 9, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 7, 30, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 20, 24, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 0, 0, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 13, 26, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 3, 59, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 0, 18, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 14, 54, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 7, 48, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 8, 6, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 6, 16, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 20, 3, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 20, 28, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 22, 54, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 17, 57, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 15, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 8, 32, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 22, 30, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 13, 3, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 5, 56, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 1, 29, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 19, 5, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 17, 52, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 1, 10, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 15, 16, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 18, 58, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 27, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 6, 54, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 5, 20, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 8, 24, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 58, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 3, 23, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 2, 12, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 19, 22, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 6, 31, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 0, 47, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 3, 36, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 15, 54, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 16, 51, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 7, 27, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 35, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 0, 51, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 18, 59, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 7, 37, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 256,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 18, 43, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 14, 47, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 257,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 7, 10, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 5, 19, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 16, 23, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 23, 45, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 0, 13, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 1, 48, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 8, 1, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 9, 36, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 8, 28, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 17, 51, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 4, 20, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 22, 3, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 4, 38, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 14, 52, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 0, 54, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 10, 41, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 3, 33, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 15, 37, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 32, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 19, 15, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 44, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 5, 51, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 6, 25, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 4, 21, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 13, 8, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 2, 19, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 12, 12, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 18, 41, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 4, 53, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 19, 26, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 20, 34, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 6, 14, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 5, 52, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 18, 21, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 5, 44, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 18, 58, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 1, 7, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 23, 24, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 2, 28, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 4, 21, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 2, 11, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 10, 41, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 6, 0, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 23, 18, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 0, 43, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 8, 21, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 15, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 9, 8, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 14, 45, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 5, 19, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 8, 21, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 19, 48, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 0, 14, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 11, 15, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 15, 20, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 9, 5, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 3, 46, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 15, 6, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 1, 13, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 12, 47, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 15, 26, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 23, 30, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 18, 3, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 18, 14, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 18, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 3, 7, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 21, 43, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 18, 59, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 12, 52, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 17, 28, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 15, 55, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 4, 56, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 45, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 18, 39, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 21, 37, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 16, 9, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 10, 50, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 5, 44, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 6, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 18, 49, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 12, 25, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 1, 43, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 298,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 20, 48, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 17, 16, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 5, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 8, 26, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 19, 52, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 1, 54, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 2, 14, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 15, 17, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 22, 2, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 3, 31, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 21, 43, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 5, 2, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 22, 40, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 3, 42, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 31, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 15, 26, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 15, 45, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 9, 24, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 4, 5, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 6, 39, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 22, 48, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 18, 16, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 15, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 2, 7, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 11, 49, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 19, 4, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 13, 39, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 1, 1, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 21, 6, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 16, 46, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 11, 48, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 0, 55, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 11, 14, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 9, 50, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 4, 5, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 5, 54, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 11, 40, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 9, 14, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 20, 52, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 8, 19, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 4, 0, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 23, 40, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 15, 3, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 14, 20, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 20, 28, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 11, 22, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 321,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 2, 47, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 6, 17, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 7, 0, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 2, 16, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 35, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 1, 9, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 6, 52, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 1, 30, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 17, 23, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 10, 19, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 15, 25, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 45, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 20, 33, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 17, 31, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 4, 46, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 13, 8, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 46, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 8, 33, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 20, 15, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 0, 53, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 16, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 21, 29, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 20, 39, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 23, 45, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 333,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 22, 15, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 5, 21, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 40, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 1, 26, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 23, 51, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 3, 55, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 20, 20, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 23, 48, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 13, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 8, 6, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 2, 33, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 23, 21, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 19, 56, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 10, 3, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 8, 22, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 4, 44, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 17, 13, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 13, 16, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 5, 43, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 13, 19, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 7, 13, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 21, 22, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 14, 32, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 8, 16, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 5, 6, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 23, 25, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 4, 25, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 13, 50, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 31, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 1, 1, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 2, 39, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 4, 11, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 16, 52, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 6, 58, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 14, 19, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 16, 21, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 2, 24, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 17, 41, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 7, 19, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 8, 4, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 21, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 19, 26, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 19, 28, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 11, 43, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 22, 2, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 19, 34, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 5, 26, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 10, 58, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 5, 4, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 11, 0, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 14, 54, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 8, 24, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 10, 4, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 10, 41, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 3, 10, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 23, 9, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 0, 6, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 17, 21, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 1, 14, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 8, 50, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 8, 2, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 9, 11, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 8, 39, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 16, 14, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 58, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 10, 1, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 18, 23, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 8, 42, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 13, 14, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 13, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 17, 26, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 6, 55, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 11, 38, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 13, 15, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 0, 18, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 5, 26, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 16, 19, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 21, 11, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 4, 34, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 7, 20, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 39, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 11, 57, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 4, 10, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 13, 5, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 21, 4, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 10, 28, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 1, 22, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 6, 24, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 4, 34, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 1, 4, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 3, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 22, 0, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 3, 43, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 15, 30, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 23, 15, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 12, 38, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 381,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 22, 5, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 2, 47, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 4, 18, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 9, 29, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 0, 43, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 3, 30, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 19, 11, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 11, 35, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 53, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 20, 29, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 23, 36, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 3, 3, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 10, 42, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 8, 55, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 7, 24, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 5, 2, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 34, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 8, 18, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 6, 30, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 6, 20, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 23, 24, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 7, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 4, 13, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 2, 21, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 9, 2, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 0, 27, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 52, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 5, 45, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 0, 24, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 19, 55, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 396,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 21, 39, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 2, 14, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 11, 2, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 9, 6, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 18, 15, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 1, 9, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 7, 40, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 3, 56, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 21, 27, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 4, 36, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 7, 20, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 21, 23, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 23, 56, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 23, 20, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 2, 45, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 17, 47, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 1, 15, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 17, 40, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 8, 47, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 22, 40, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 22, 26, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 19, 57, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 14, 33, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 5, 16, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 42, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 17, 8, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 19, 41, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 20, 24, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 47, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 16, 4, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 7, 53, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 0, 13, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 3, 35, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 16, 47, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 19, 15, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 12, 22, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 0, 16, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 5, 37, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 5, 28, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 15, 39, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 4, 40, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 21, 19, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 13, 38, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 16, 26, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 5, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 17, 17, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 2, 45, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 11, 42, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 26, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 11, 53, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 4, 14, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 22, 55, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 17, 35, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 14, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 9, 7, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 11, 28, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 424,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 4, 18, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 12, 51, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 4, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 18, 41, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 8, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 12, 25, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 9, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 13, 3, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 15, 33, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 4, 4, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 1, 29, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 16, 13, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 10, 59, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 20, 51, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 12, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 13, 1, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 6, 11, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 19, 46, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 6, 51, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 15, 35, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 3, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 21, 51, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 23, 16, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 22, 19, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 18, 52, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 9, 26, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 17, 5, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 17, 17, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 28, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 23, 5, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 10, 33, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 10, 35, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 12, 9, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 17, 54, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 14, 5, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 5, 48, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 21, 46, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 22, 19, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 7, 12, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 21, 49, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 22, 44, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 21, 55, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 15, 29, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 13, 31, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 9, 57, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 11, 11, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 17, 10, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 14, 32, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 21, 20, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 2, 47, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 25, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 18, 43, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 17, 55, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 18, 4, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 4, 24, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 12, 43, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 17, 47, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 21, 54, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 13, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 21, 15, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 8, 30, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 18, 20, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 1, 42, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 3, 32, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 21, 10, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 15, 53, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 7, 13, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 20, 2, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 1, 34, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 22, 4, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 20, 34, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 0, 1, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 5, 29, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 7, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 8, 7, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 21, 36, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 0, 42, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 17, 41, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 9, 5, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 2, 18, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 19, 47, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 17, 23, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 13, 49, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 3, 4, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 5, 37, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 17, 30, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 20, 55, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 22, 7, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 7, 4, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 15, 46, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 2, 7, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 11, 31, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 17, 43, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 11, 36, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 2, 45, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 11, 39, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 5, 48, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 9, 2, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 5, 21, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 9, 49, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 9, 33, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 1, 8, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 5, 49, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 5, 55, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 10, 54, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 2, 33, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 19, 42, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 10, 25, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 23, 59, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 6, 32, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 3, 51, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 7, 35, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 0, 7, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 23, 37, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 3, 17, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 6, 53, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 14, 45, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 7, 40, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 19, 11, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 8, 51, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 484,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 40, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 14, 33, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 0, 41, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 6, 23, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 14, 41, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 16, 59, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 6, 24, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 23, 27, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 23, 5, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 7, 25, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 21, 55, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 12, 30, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 10, 54, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 8, 20, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 5, 4, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 7, 6, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 19, 15, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 17, 0, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 6, 55, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 14, 27, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 0, 55, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 7, 6, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 6, 14, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 19, 17, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 7, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 12, 32, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 20, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 12, 59, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 15, 13, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 6, 56, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 21, 22, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 21, 12, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 18, 29, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 17, 18, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 23, 44, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 16, 49, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 18, 56, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 14, 15, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 1, 14, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 5, 52, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 18, 51, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 11, 58, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 19, 58, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 14, 31, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 22, 40, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 23, 4, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 5, 16, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 1, 56, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 23, 10, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 12, 30, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 2, 7, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 13, 42, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 10, 39, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 21, 9, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 19, 53, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 12, 30, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 6, 58, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 23, 5, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 21, 27, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 23, 43, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 18, 55, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 12, 21, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 6, 18, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 14, 45, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 6, 21, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 21, 31, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 20, 9, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 1, 25, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 1, 37, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 3, 1, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 19, 41, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 15, 31, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 10, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 6, 18, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 15, 18, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 0, 7, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 10, 42, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 23, 10, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 14, 58, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 2, 42, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 13, 57, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 10, 22, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 0, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 22, 24, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 3, 48, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 12, 9, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 16, 39, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 14, 7, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 23, 58, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 15, 42, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 38, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 1, 59, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 18, 21, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 7, 38, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 10, 25, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 22, 4, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 0, 51, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 15, 55, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 18, 39, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 22, 48, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 10, 21, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 16, 57, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 18, 28, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 3, 49, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 2, 10, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 12, 47, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 13, 9, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 15, 40, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 8, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 19, 32, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 3, 47, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 17, 9, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 49, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 18, 22, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 8, 27, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 7, 59, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 18, 4, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 12, 5, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 16, 45, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 17, 41, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 0, 34, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 20, 31, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 15, 54, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 12, 37, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 22, 5, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 13, 19, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 18, 6, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 23, 1, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 20, 11, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 22, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 4, 57, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 2, 29, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 11, 35, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 8, 18, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 21, 9, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 9, 57, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 21, 58, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 16, 24, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 10, 47, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 21, 0, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 8, 10, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 16, 26, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 2, 30, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 9, 6, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 556,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 14, 33, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 14, 35, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 18, 22, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 11, 28, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 23, 7, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 19, 11, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 20, 20, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 2, 29, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 35, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 22, 28, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 21, 21, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 18, 37, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 1, 56, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 17, 41, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 27, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 3, 2, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 20, 15, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 23, 16, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 3, 27, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 1, 31, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 21, 51, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 6, 16, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 0, 11, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 4, 18, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 7, 42, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 5, 18, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 14, 4, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 17, 1, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 6, 59, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 6, 9, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 18, 51, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 7, 59, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 11, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 8, 2, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 8, 23, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 0, 33, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 0, 54, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 15, 41, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 49, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 13, 33, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 10, 4, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 1, 26, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 17, 49, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 14, 37, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 20, 43, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 22, 30, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 38, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 0, 6, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 13, 34, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 6, 3, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 15, 40, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 22, 33, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 18, 22, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 20, 50, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 10, 41, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 12, 59, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 5, 35, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 6, 34, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 22, 40, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 13, 14, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 19, 32, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 16, 38, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 18, 31, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 5, 54, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 2, 20, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 18, 56, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 9, 32, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 17, 53, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 10, 47, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 23, 53, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 45, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 7, 45, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 21, 14, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 10, 10, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 7, 37, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 4, 40, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 23, 46, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 1, 10, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 3, 34, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 5, 16, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 6, 51, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 20, 53, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 19, 36, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 8, 7, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 5, 42, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 45, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 15, 48, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 3, 51, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 12, 42, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 21, 8, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 3, 0, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 7, 27, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 17, 54, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 7, 41, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 16, 15, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 10, 18, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 7, 22, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 12, 1, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 16, 19, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 5, 24, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 3, 50, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 4, 56, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 8, 18, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 16, 27, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 11, 51, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 6, 44, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 6, 46, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 23, 31, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 18, 44, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 5, 22, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 21, 37, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 0, 17, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 3, 27, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 21, 25, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 0, 42, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 13, 57, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 23, 5, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 1, 24, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 615,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 5, 46, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 22, 52, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 7, 25, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 8, 37, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 20, 19, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 7, 40, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 1, 43, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 0, 19, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 19, 30, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 21, 31, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 4, 14, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 12, 53, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 44, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 2, 4, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 13, 25, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 14, 10, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 28, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 18, 0, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 18, 5, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 23, 58, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 20, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 3, 3, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 11, 56, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 3, 48, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 17, 16, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 10, 12, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 12, 2, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 53, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 22, 29, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 13, 11, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 6, 18, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 15, 44, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 22, 55, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 13, 52, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 632,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 14, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 9, 27, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 4, 48, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 19, 6, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 4, 52, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 7, 29, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 15, 22, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 22, 27, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 18, 46, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 13, 48, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 16, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 9, 23, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 8, 57, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 23, 58, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 22, 19, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 20, 5, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 7, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 20, 38, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 0, 0, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 7, 37, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 0, 18, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 0, 42, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 22, 58, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 1, 4, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 14, 46, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 19, 18, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 3, 27, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 18, 22, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 31, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 10, 59, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 11, 8, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 21, 31, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 17, 12, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 21, 47, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 13, 12, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 17, 19, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 19, 32, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 4, 31, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 23, 16, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 18, 53, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 2, 54, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 20, 14, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 12, 0, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 7, 21, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 2, 24, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 0, 33, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 6, 22, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 20, 16, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 20, 47, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 1, 3, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 6, 32, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 14, 26, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 14, 21, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 14, 54, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 13, 26, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 17, 8, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 0, 9, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 16, 24, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 15, 54, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 11, 23, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 12, 23, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 2, 52, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 10, 58, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 20, 29, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 16, 21, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 3, 56, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 8, 4, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 18, 29, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 12, 4, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 2, 11, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 22, 22, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 2, 8, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 9, 5, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 3, 39, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 20, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 19, 31, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 4, 9, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 12, 10, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 22, 6, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 10, 25, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 1, 20, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 18, 47, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 48, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 12, 8, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 16, 55, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 9, 40, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 12, 22, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 2, 35, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 21, 5, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 0, 23, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 14, 31, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 19, 33, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 17, 41, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 5, 42, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 53, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 8, 40, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 7, 22, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 16, 42, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 18, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 21, 37, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 13, 15, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 16, 30, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 1, 48, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 38, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 17, 13, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 10, 41, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 9, 53, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 13, 3, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 9, 8, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 20, 47, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 3, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 4, 41, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 3, 42, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 20, 16, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 20, 3, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 6, 31, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 3, 34, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 13, 58, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 9, 55, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 15, 14, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 14, 50, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 5, 2, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 17, 23, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 6, 43, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 2, 30, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 14, 52, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 19, 9, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 11, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 0, 11, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 6, 38, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 5, 59, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 9, 9, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 9, 38, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 9, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 3, 1, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 19, 59, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 1, 24, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 58, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 15, 57, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 11, 13, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 13, 25, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 1, 21, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 17, 50, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 55, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 0, 3, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 2, 50, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 15, 33, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 1, 51, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 17, 20, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 1, 21, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 23, 18, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 29, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 6, 15, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 5, 56, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 15, 47, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 1, 20, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 6, 0, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 17, 38, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 8, 30, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 16, 52, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 5, 9, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 9, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 16, 41, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 714,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 7, 50, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 18, 30, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 7, 42, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 2, 16, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 46, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 2, 44, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 2, 13, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 4, 6, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 17, 31, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 16, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 12, 31, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 18, 10, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 12, 33, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 21, 37, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 2, 27, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 20, 22, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 50, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 1, 54, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 1, 49, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 17, 16, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 8, 13, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 4, 58, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 725,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 57, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 19, 53, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 9, 34, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 8, 31, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 13, 2, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 4, 39, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 11, 32, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 10, 26, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 28, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 9, 10, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 22, 8, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 20, 2, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 22, 46, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 7, 35, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 10, 33, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 5, 7, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 18, 45, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 7, 27, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 14, 1, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 19, 29, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 21, 15, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 17, 0, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 4, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 12, 37, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 50, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 1, 45, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 15, 48, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 14, 57, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 20, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 16, 26, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 34, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 10, 20, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 6, 40, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 13, 9, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 0, 38, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 8, 34, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 7, 22, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 22, 41, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 41, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 0, 4, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 13, 33, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 12, 29, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 5, 35, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 2, 12, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 21, 56, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 9, 21, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 17, 20, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 15, 16, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 10, 25, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 8, 2, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 12, 58, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 13, 38, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 19, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 15, 41, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 0, 53, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 15, 58, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 22, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 9, 50, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 21, 28, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 7, 23, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 15, 9, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 16, 5, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 19, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 6, 15, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 8, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 13, 18, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 9, 36, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 23, 23, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 7, 10, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 4, 10, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 5, 19, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 7, 20, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 22, 45, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 15, 40, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 16, 59, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 16, 13, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 13, 27, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 6, 32, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 18, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 14, 37, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 21, 23, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 16, 55, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 12, 4, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 17, 14, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 15, 7, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 15, 2, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 17, 46, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 23, 33, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 8, 46, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 17, 45, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 11, 13, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 11, 14, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 1, 32, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 7, 25, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 19, 20, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 16, 11, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 12, 56, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 15, 2, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 20, 33, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 21, 42, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 2, 45, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 13, 0, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 5, 56, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 12, 53, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 777,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 10, 58, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 22, 41, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 4, 47, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 10, 48, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 0, 56, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 23, 38, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 14, 8, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 17, 24, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 5, 15, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 19, 20, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 17, 59, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 14, 8, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 13, 31, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 22, 38, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 784,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 40, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 3, 21, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 4, 54, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 20, 23, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 3, 52, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 20, 23, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 12, 10, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 22, 54, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 17, 30, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 7, 15, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 59, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 12, 3, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 6, 58, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 7, 45, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 11, 43, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 16, 56, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 16, 51, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 18, 53, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 4, 49, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 15, 36, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 31, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 18, 27, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 9, 59, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 15, 22, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 19, 21, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 17, 17, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 22, 43, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 14, 22, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 4, 49, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 8, 4, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 2, 4, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 7, 33, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 7, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 1, 27, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 16, 51, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 22, 9, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 0, 33, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 19, 21, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 19, 47, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 11, 17, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 1, 33, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 7, 11, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 4, 38, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 6, 24, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 1, 44, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 13, 45, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 6, 7, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 22, 44, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 21, 40, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 16, 39, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 20, 5, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 1, 57, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 45, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 10, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 15, 54, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 2, 28, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 15, 42, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 17, 55, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 12, 31, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 2, 19, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 18, 31, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 16, 57, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 11, 53, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 19, 59, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 13, 58, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 6, 0, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 6, 52, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 9, 44, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 12, 4, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 15, 38, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 22, 57, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 4, 23, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 18, 53, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 13, 43, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 8, 23, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 14, 38, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 4, 15, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 3, 44, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 18, 57, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 7, 24, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 2, 22, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 15, 26, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 17, 29, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 13, 56, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 17, 29, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 13, 41, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 3, 55, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 2, 57, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 17, 32, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 18, 13, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 19, 3, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 5, 5, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 20, 44, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 20, 53, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 8, 47, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 3, 23, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 832,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 10, 1, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 16, 31, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 5, 14, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 10, 24, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 4, 50, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 7, 3, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 1, 52, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 6, 19, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 7, 57, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 1, 25, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 4, 55, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 8, 36, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 7, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 3, 44, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 20, 42, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 22, 19, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 14, 15, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 4, 9, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 8, 5, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 13, 10, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 5, 3, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 11, 32, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 12, 40, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 13, 54, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 9, 45, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 19, 51, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 5, 20, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 20, 38, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 15, 3, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 17, 15, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 7, 1, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 1, 54, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 5, 23, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 13, 29, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 3, 20, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 18, 18, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 4, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 15, 45, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 10, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 1, 0, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 13, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 22, 49, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 2, 41, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 23, 51, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 13, 6, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 9, 12, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 13, 0, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 21, 0, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 22, 0, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 21, 46, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 6, 55, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 18, 58, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 4, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 10, 25, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 14, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 23, 21, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 39, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 3, 17, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 6, 37, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 19, 31, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 0, 8, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 15, 24, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 2, 49, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 5, 0, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 7, 44, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 20, 10, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 37, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 8, 34, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 16, 43, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 12, 9, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 14, 59, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 18, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 19, 50, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 15, 33, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 11, 10, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 1, 53, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 5, 46, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 15, 36, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 28, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 17, 14, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 872,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 23, 29, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 8, 1, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 22, 17, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 5, 2, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 0, 19, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 8, 43, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 9, 53, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 5, 24, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 2, 32, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 9, 39, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 8, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 13, 10, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 13, 5, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 13, 17, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 17, 40, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 14, 14, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 4, 57, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 17, 5, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 14, 46, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 18, 23, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 2, 32, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 15, 44, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 56, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 5, 54, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 24, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 12, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 26, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 17, 17, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 22, 16, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 6, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 5, 23, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 1, 32, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 48, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 5, 54, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 9, 56, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 2, 24, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 18, 23, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 3, 10, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 23, 15, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 1, 2, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 3, 26, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 20, 4, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 15, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 9, 45, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 3, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 23, 46, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 15, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 4, 32, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 19, 22, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 6, 38, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 12, 30, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 15, 33, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 898,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 5, 44, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 7, 40, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 9, 44, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 13, 59, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 19, 36, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 14, 31, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 3, 33, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 19, 35, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 23, 53, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 21, 12, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 1, 8, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 11, 48, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 1, 38, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 23, 35, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 14, 47, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 1, 35, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 14, 42, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 11, 52, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 2, 35, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 11, 22, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 14, 43, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 16, 33, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 14, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 18, 9, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 22, 13, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 5, 36, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 40, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 17, 38, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 10, 27, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 18, 43, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 7, 39, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 22, 8, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 0, 27, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 8, 12, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 20, 36, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 0, 24, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 7, 1, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 14, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 15, 50, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 9, 46, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 22, 18, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 2, 42, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 22, 17, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 0, 38, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 5, 4, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 6, 59, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 7, 14, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 8, 22, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 48, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 19, 1, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 13, 18, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 19, 44, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 9, 28, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 6, 54, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 13, 32, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 3, 33, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 6, 13, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 6, 46, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 22, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 18, 2, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 15, 42, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 7, 22, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 15, 13, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 9, 23, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 18, 49, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 19, 28, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 8, 26, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 5, 36, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 6, 4, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 16, 49, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 10, 46, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 7, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 9, 4, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 21, 27, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 1, 14, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 5, 46, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 17, 37, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 3, 24, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 13, 20, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 17, 22, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 5, 11, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 20, 35, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 5, 33, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 20, 11, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 22, 23, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 7, 5, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 15, 31, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 14, 10, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 23, 8, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 23, 42, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 2, 56, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 19, 18, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 11, 36, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 23, 18, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 945,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 21, 59, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 1, 36, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 21, 6, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 8, 15, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 13, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 3, 13, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 21, 58, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 14, 17, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 23, 0, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 12, 41, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 7, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 23, 31, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 14, 37, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 21, 58, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 17, 3, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 18, 22, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 21, 15, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 1, 3, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 4, 2, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 21, 9, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 3, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 1, 50, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 0, 13, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 16, 2, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 8, 35, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 12, 16, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 4, 18, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 1, 42, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 9, 33, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 2, 15, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 23, 48, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 23, 37, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 20, 32, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 15, 8, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 12, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 17, 41, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 18, 8, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 20, 9, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 8, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 1, 52, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 19, 54, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 8, 0, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 2, 19, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 1, 31, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 12, 33, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 16, 47, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 1, 26, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 0, 19, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 37, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 4, 25, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 17, 37, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 23, 30, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 12, 53, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 7, 27, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 5, 23, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 12, 28, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 11, 32, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 8, 48, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 14, 42, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 10, 49, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 13, 21, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 14, 2, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 4, 12, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 13, 18, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 12, 31, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 5, 31, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 7, 27, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 1, 59, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 4, 42, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 16, 1, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 12, 8, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 14, 45, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 7, 26, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 11, 43, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 0, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 4, 18, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 1, 19, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 8, 17, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 1, 18, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 5, 2, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 11, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 9, 29, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 57, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 12, 37, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 19, 32, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 0, 19, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 1, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 12, 25, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 21, 33, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 2, 57, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 0, 40, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 0, 51, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 10, 50, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 15, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 3, 28, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 23, 15, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 8, 39, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 10, 33, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 12, 56, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 15, 22, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 5, 14, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 14, 12, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 1, 19, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 6, 9, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 6, 29, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 16, 45, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 11, 22, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 8, 8, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 4, 32, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 3, 23, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 16, 29, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 2, 20, 41, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageContent",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 2, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 9, 32, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 2, 59, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 17, 42, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 21, 42, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 6, 35, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 21, 33, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 22, 10, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 13, 21, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 18, 43, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 5, 10, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 23, 16, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 23, 12, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 3, 26, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 21, 36, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 21, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 0, 23, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 0, 42, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 0, 15, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 11, 22, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 8, 31, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 11, 48, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 45, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 13, 2, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 41, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 18, 16, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 21, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 6, 23, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 17, 48, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 17, 25, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 51, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 6, 21, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 9, 19, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 0, 11, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 5, 51, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 14, 38, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 9, 25, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 12, 53, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 12, 23, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 14, 44, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 15, 16, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 5, 26, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 29, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 2, 58, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 11, 45, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 23, 23, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 2, 50, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 0, 32, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 8, 0, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 23, 2, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 12, 41, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 10, 47, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 16, 18, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 20, 33, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 22, 19, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 6, 28, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 8, 54, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 15, 20, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 21, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 18, 27, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 13, 4, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 5, 12, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 15, 53, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 22, 46, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 7, 55, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 15, 51, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 7, 2, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 8, 8, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 5, 44, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 4, 28, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 11, 30, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 6, 58, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 22, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 14, 28, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 0, 10, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 2, 33, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 4, 20, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 4, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 28, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 20, 0, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 4, 19, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 23, 53, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 23, 22, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 9, 56, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 2, 59, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 8, 42, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 1, 15, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 8, 23, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 9, 56, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 16, 41, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 23, 13, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 11, 14, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 3, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 7, 4, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 2, 34, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 5, 25, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 9, 52, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 6, 54, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 23, 28, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 9, 40, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 16, 6, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 18, 22, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 2, 16, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 2, 36, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 15, 50, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 14, 14, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 21, 15, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 21, 40, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 8, 55, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 3, 21, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 14, 14, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 8, 29, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 21, 21, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 8, 35, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 1, 19, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 14, 32, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 5, 23, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 7, 18, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 17, 21, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 12, 22, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 11, 49, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 7, 14, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 6, 38, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 2, 2, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 3, 37, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 12, 8, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 0, 31, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 17, 23, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 5, 48, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 22, 55, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 11, 41, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 18, 2, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 2, 43, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 17, 45, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 19, 3, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 10, 27, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 52, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 16, 11, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 5, 0, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 6, 56, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 7, 39, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 0, 49, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 4, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 13, 10, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 16, 48, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 18, 12, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 3, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 0, 32, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 10, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 13, 50, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 21, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 15, 59, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 7, 12, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 8, 13, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 13, 43, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 11, 18, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 19, 44, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 14, 30, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 10, 9, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 13, 54, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 12, 31, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 7, 53, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 4, 2, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 15, 46, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 21, 12, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 21, 28, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 21, 9, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 16, 10, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 6, 21, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 12, 36, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 0, 32, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 0, 53, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 14, 56, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 23, 26, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 1, 26, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 14, 16, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 5, 19, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 4, 48, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 33, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 12, 23, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 22, 1, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 21, 13, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 6, 3, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 9, 47, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 15, 46, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 5, 53, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 3, 37, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 6, 51, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 0, 22, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 10, 5, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 4, 36, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 13, 27, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 12, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 2, 8, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 57, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 12, 35, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 20, 8, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 10, 55, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 11, 35, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 13, 9, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 13, 8, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 21, 56, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 21, 45, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 15, 56, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 7, 28, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 6, 1, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 9, 53, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 10, 41, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 4, 29, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 10, 9, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 10, 35, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 16, 12, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 17, 44, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 11, 56, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 11, 7, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 6, 54, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 18, 56, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 13, 11, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 21, 16, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 5, 16, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 6, 31, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 9, 8, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 3, 12, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 13, 40, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 16, 0, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 1, 19, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 5, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 16, 7, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 5, 42, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 2, 0, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 4, 48, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 10, 3, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 1, 29, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 7, 24, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 19, 3, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 14, 1, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 40, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 15, 36, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 23, 24, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 17, 24, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 16, 46, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 9, 46, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 17, 53, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 4, 53, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 17, 55, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 3, 10, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 0, 2, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 0, 37, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 0, 16, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 16, 22, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 21, 56, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 20, 26, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 2, 57, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 19, 32, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 23, 46, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 0, 30, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 6, 3, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 7, 34, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 36, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 19, 52, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 23, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 23, 26, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 6, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 21, 59, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 35, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 0, 2, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 6, 48, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 4, 21, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 23, 6, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 15, 53, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 3, 38, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 7, 53, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 9, 49, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 4, 2, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 38, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 13, 57, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 21, 8, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 9, 17, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 4, 29, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 21, 36, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 0, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 2, 22, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 0, 36, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 8, 44, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 9, 20, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 16, 32, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 4, 47, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 20, 53, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 1, 24, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 1, 28, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 23, 18, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 23, 38, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 6, 2, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 18, 31, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 5, 51, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 16, 46, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 6, 41, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 19, 18, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 16, 39, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 16, 40, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 18, 36, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 10, 4, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 3, 56, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 23, 11, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 9, 53, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 21, 5, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 19, 59, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 13, 23, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 13, 28, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 2, 7, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 37, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 17, 46, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 17, 45, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 18, 55, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 10, 44, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 8, 22, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 18, 59, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 10, 30, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 49, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 2, 1, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 9, 6, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 21, 58, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 17, 15, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 20, 17, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 11, 39, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 7, 15, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 9, 47, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 11, 10, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 14, 26, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 1, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 9, 53, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 14, 18, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 2, 14, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 0, 50, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 23, 42, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 6, 15, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 4, 49, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 12, 23, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 18, 39, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 1, 4, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 29, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 16, 16, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 6, 35, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 19, 33, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 22, 58, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 5, 2, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 7, 14, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 23, 12, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 11, 6, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 22, 42, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 22, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 8, 42, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 20, 15, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 22, 12, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 1, 36, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 6, 37, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 13, 32, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 21, 44, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 13, 18, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 5, 13, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 17, 49, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 0, 23, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 18, 19, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 21, 55, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 13, 4, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 3, 6, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 6, 46, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 22, 24, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 13, 17, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 10, 12, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 56, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 6, 0, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 10, 37, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 14, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 3, 35, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 9, 10, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 13, 46, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 15, 27, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 5, 38, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 12, 29, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 191,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 49, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 17, 50, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 54, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 9, 26, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 18, 10, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 21, 37, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 9, 11, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 18, 24, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 14, 49, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 9, 59, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 12, 29, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 8, 1, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 7, 36, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 18, 5, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 22, 51, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 12, 14, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 11, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 18, 59, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 5, 28, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 20, 29, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 8, 38, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 23, 5, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 12, 46, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 10, 7, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 22, 10, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 19, 50, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 41, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 10, 21, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 22, 14, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 4, 54, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 4, 3, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 3, 56, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 23, 15, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 3, 30, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 3, 52, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 13, 27, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 13, 33, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 17, 10, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 1, 35, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 16, 57, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 6, 34, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 8, 17, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 18, 50, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 11, 15, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 19, 11, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 7, 43, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 4, 14, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 23, 22, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 7, 40, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 11, 6, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 6, 12, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 6, 15, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 14, 57, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 22, 29, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 11, 34, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 9, 38, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 9, 37, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 18, 57, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 20, 5, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 1, 56, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 1, 48, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 9, 1, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 9, 49, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 6, 43, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 21, 52, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 21, 19, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 9, 56, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 4, 24, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 7, 15, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 8, 5, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 5, 37, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 17, 7, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 23, 1, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 10, 18, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 228,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 2, 53, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 3, 47, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 17, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 14, 37, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 23, 34, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 0, 10, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 20, 32, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 22, 2, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 20, 24, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 6, 50, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 21, 15, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 13, 39, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 39, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 12, 3, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 11, 25, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 16, 47, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 19, 13, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 6, 0, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 3, 55, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 15, 14, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 7, 15, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 20, 11, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 1, 15, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 4, 7, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 4, 32, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 23, 40, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 20, 24, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 5, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 16, 6, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 6, 50, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 7, 56, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 2, 52, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 21, 36, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 6, 34, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 23, 54, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 7, 7, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 14, 8, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 5, 18, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 1, 52, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 10, 4, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 19, 35, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 22, 9, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 1, 36, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 5, 16, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 10, 27, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 1, 46, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 21, 24, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 18, 22, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 22, 30, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 1, 13, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 14, 17, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 11, 6, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 20, 50, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 14, 36, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 6, 38, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 16, 1, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 256,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 12, 43, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 12, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 257,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 11, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 20, 23, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 22, 55, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 15, 56, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 2, 22, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 3, 26, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 36, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 16, 54, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 23, 24, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 0, 15, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 5, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 23, 18, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 23, 15, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 7, 30, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 11, 36, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 17, 8, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 18, 10, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 10, 45, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 10, 27, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 18, 35, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 18, 33, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 2, 57, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 10, 28, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 19, 43, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 21, 5, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 13, 40, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 14, 6, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 4, 21, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 6, 10, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 0, 14, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 23, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 5, 55, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 0, 9, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 4, 49, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 21, 5, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 9, 21, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 51, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 2, 18, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 8, 20, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 5, 52, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 5, 29, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 19, 32, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 22, 30, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 3, 46, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 16, 46, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 0, 42, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 6, 43, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 14, 11, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 5, 3, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 7, 54, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 18, 18, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 23, 10, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 0, 59, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 19, 25, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 2, 16, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 1, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 10, 48, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 20, 7, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 22, 28, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 12, 8, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 14, 37, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 12, 52, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 0, 10, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 5, 24, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 5, 26, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 13, 49, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 17, 20, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 16, 0, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 10, 10, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 8, 28, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 5, 17, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 19, 43, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 17, 47, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 22, 13, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 14, 59, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 10, 33, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 13, 48, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 11, 36, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 5, 31, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 19, 17, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 4, 22, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 16, 53, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 298,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 8, 40, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 16, 51, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 10, 36, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 3, 36, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 30, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 21, 16, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 10, 58, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 15, 47, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 33, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 11, 58, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 10, 18, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 3, 40, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 6, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 5, 41, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 7, 52, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 21, 58, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 5, 57, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 10, 12, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 5, 24, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 15, 18, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 7, 42, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 2, 54, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 1, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 18, 27, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 20, 35, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 13, 27, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 5, 46, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 16, 25, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 23, 9, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 22, 38, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 18, 6, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 14, 0, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 9, 14, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 16, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 4, 51, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 22, 4, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 12, 58, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 9, 54, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 24, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 23, 3, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 13, 34, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 3, 39, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 11, 23, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 22, 51, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 13, 54, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 6, 32, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 321,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 8, 12, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 10, 4, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 44, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 17, 29, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 4, 22, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 20, 52, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 11, 53, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 7, 53, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 12, 21, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 15, 34, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 4, 48, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 16, 6, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 6, 44, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 4, 13, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 14, 57, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 21, 41, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 1, 32, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 22, 12, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 9, 12, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 20, 32, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 21, 43, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 10, 30, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 23, 33, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 21, 52, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 333,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 12, 45, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 14, 29, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 3, 17, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 9, 3, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 19, 26, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 20, 24, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 18, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 4, 50, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 19, 5, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 20, 33, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 6, 18, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 3, 25, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 10, 34, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 19, 45, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 21, 16, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 8, 39, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 17, 13, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 7, 0, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 17, 35, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 18, 1, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 11, 29, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 4, 40, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 20, 22, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 3, 50, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 7, 21, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 19, 11, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 23, 50, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 5, 48, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 17, 19, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 11, 53, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 25, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 4, 15, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 17, 31, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 22, 53, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 1, 27, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 21, 15, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 9, 10, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 4, 49, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 22, 29, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 9, 49, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 9, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 17, 36, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 23, 46, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 13, 18, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 8, 32, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 8, 25, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 4, 53, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 7, 55, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 8, 44, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 5, 52, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 20, 33, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 2, 38, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 13, 23, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 11, 39, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 19, 0, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 11, 24, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 6, 25, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 2, 57, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 11, 21, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 11, 5, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 12, 58, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 23, 22, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 14, 17, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 4, 14, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 22, 14, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 19, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 4, 31, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 9, 11, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 59, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 5, 57, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 19, 20, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 22, 44, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 1, 54, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 22, 45, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 28, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 10, 33, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 20, 16, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 0, 18, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 20, 46, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 0, 0, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 23, 26, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 1, 53, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 44, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 21, 36, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 8, 51, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 1, 56, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 13, 24, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 23, 58, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 45, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 3, 16, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 16, 3, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 5, 53, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 3, 43, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 15, 7, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 22, 7, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 7, 7, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 381,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 14, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 11, 15, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 25, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 16, 1, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 58, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 14, 45, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 4, 39, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 1, 40, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 10, 31, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 2, 49, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 15, 0, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 14, 25, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 19, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 16, 29, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 1, 55, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 14, 26, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 8, 0, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 18, 15, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 12, 38, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 22, 31, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 16, 0, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 23, 57, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 0, 39, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 9, 35, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 21, 19, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 11, 8, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 18, 42, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 8, 10, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 14, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 5, 50, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 396,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 35, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 4, 42, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 17, 31, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 21, 28, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 0, 9, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 22, 9, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 11, 42, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 20, 31, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 18, 37, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 2, 39, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 6, 25, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 4, 53, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 18, 43, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 21, 34, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 3, 34, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 23, 11, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 4, 36, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 4, 48, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 15, 59, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 19, 59, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 13, 50, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 2, 27, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 19, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 12, 53, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 12, 32, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 20, 4, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 18, 36, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 15, 59, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 5, 23, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 7, 14, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 22, 43, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 4, 13, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 9, 12, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 17, 6, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 20, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 4, 28, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 8, 5, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 23, 21, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 14, 21, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 20, 7, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 9, 41, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 21, 46, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 13, 45, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 8, 5, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 10, 20, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 14, 21, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 19, 55, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 1, 17, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 17, 51, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 21, 2, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 8, 7, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 12, 39, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 34, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 19, 25, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 16, 20, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 2, 22, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 424,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 22, 21, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 23, 26, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 2, 19, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 16, 2, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 20, 4, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 20, 35, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 0, 29, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 2, 28, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 18, 21, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 7, 17, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 8, 55, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 23, 13, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 23, 16, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 11, 25, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 26, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 16, 6, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 9, 2, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 23, 6, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 7, 41, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 13, 16, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 25, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 15, 42, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 19, 30, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 9, 12, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 18, 59, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 4, 9, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 16, 49, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 6, 43, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 54, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 16, 48, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 0, 31, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 19, 10, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 2, 30, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 11, 43, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 5, 39, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 21, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 0, 1, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 9, 51, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 17, 10, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 5, 20, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 5, 54, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 17, 41, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 4, 37, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 1, 16, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 11, 44, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 9, 22, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 20, 29, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 10, 1, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 23, 2, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 9, 5, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 3, 39, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 15, 16, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 5, 30, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 7, 16, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 20, 21, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 9, 0, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 12, 15, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 19, 50, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 10, 3, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 4, 23, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 8, 39, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 18, 24, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 21, 28, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 6, 6, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 8, 47, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 3, 56, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 8, 40, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 9, 8, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 0, 22, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 8, 55, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 21, 39, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 15, 36, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 11, 23, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 18, 34, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 3, 41, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 10, 21, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 2, 55, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 6, 49, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 2, 17, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 13, 39, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 20, 33, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 8, 13, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 3, 59, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 20, 57, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 23, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 18, 4, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 4, 36, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 16, 20, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 0, 42, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 16, 23, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 3, 0, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 4, 52, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 2, 51, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 23, 56, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 37, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 17, 35, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 18, 57, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 19, 9, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 22, 49, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 18, 55, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 4, 16, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 18, 2, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 8, 11, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 22, 34, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 15, 19, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 11, 18, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 35, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 20, 45, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 12, 7, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 17, 10, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 11, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 18, 9, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 45, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 17, 11, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 3, 15, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 0, 21, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 5, 46, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 5, 41, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 1, 26, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 5, 39, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 484,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 15, 17, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 8, 27, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 24, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 8, 44, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 21, 39, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 0, 5, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 16, 53, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 1, 34, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 2, 59, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 11, 46, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 3, 5, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 6, 28, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 8, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 11, 41, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 11, 1, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 19, 57, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 1, 30, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 19, 6, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 25, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 14, 36, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 7, 32, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 1, 1, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 21, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 4, 7, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 22, 30, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 13, 49, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 19, 18, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 18, 30, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 17, 13, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 23, 51, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 17, 6, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 12, 2, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 7, 21, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 8, 19, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 14, 30, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 5, 8, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 22, 24, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 2, 38, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 13, 52, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 11, 36, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 18, 35, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 20, 41, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 12, 27, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 23, 13, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 22, 29, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 14, 44, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 20, 36, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 17, 32, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 8, 1, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 11, 45, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 11, 16, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 8, 58, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 23, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 11, 5, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 23, 35, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 18, 8, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 8, 14, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 9, 27, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 17, 26, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 6, 46, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 12, 28, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 5, 15, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 12, 55, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 10, 7, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 3, 50, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 11, 31, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 10, 46, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 10, 38, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 11, 32, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 5, 58, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 13, 22, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 1, 38, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 22, 56, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 5, 45, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 0, 23, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 1, 7, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 19, 12, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 14, 43, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 10, 56, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 2, 48, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 23, 31, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 1, 9, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 12, 18, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 5, 36, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 1, 49, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 3, 23, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 19, 53, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 12, 52, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 8, 56, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 1, 35, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 14, 7, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 15, 34, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 7, 12, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 21, 43, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 11, 0, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 30, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 11, 52, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 30, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 23, 49, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 5, 21, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 0, 55, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 19, 8, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 13, 43, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 10, 4, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 11, 56, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 1, 8, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 15, 22, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 0, 51, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 5, 17, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 2, 27, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 3, 59, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 21, 14, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 23, 37, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 23, 37, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 36, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 6, 39, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 6, 57, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 14, 26, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 7, 12, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 22, 35, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 5, 43, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 3, 15, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 1, 27, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 22, 50, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 3, 4, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 5, 16, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 22, 34, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 6, 27, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 6, 4, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 13, 0, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 12, 39, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 22, 21, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 0, 5, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 14, 8, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 6, 49, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 14, 54, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 17, 26, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 17, 11, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 15, 20, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 3, 26, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 22, 7, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 13, 12, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 18, 26, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 556,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 21, 34, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 9, 31, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 2, 39, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 11, 38, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 1, 0, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 16, 42, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 1, 16, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 4, 51, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 0, 48, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 13, 46, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 12, 15, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 6, 26, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 18, 1, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 10, 39, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 49, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 18, 56, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 9, 9, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 23, 3, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 0, 49, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 22, 45, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 17, 8, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 9, 26, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 5, 41, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 17, 15, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 3, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 0, 43, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 16, 58, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 2, 22, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 15, 42, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 1, 14, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 9, 37, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 1, 49, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 3, 18, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 3, 8, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 7, 29, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 12, 11, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 22, 51, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 8, 20, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 15, 31, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 18, 15, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 8, 41, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 11, 46, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 15, 37, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 5, 49, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 11, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 3, 9, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 20, 51, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 10, 10, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 22, 2, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 1, 19, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 17, 26, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 0, 44, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 7, 33, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 8, 37, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 3, 50, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 5, 13, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 32, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 1, 43, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 1, 18, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 8, 49, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 3, 9, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 6, 24, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 4, 54, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 19, 43, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 23, 47, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 17, 51, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 12, 3, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 21, 19, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 12, 23, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 19, 27, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 3, 48, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 3, 13, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 18, 0, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 23, 55, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 11, 18, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 15, 2, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 5, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 16, 54, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 6, 19, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 20, 12, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 22, 19, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 4, 14, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 2, 6, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 3, 41, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 47, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 17, 19, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 7, 44, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 22, 51, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 38, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 11, 21, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 1, 41, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 6, 25, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 11, 1, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 10, 27, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 54, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 3, 16, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 1, 53, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 23, 47, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 15, 42, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 21, 51, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 0, 42, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 18, 29, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 3, 1, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 22, 10, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 1, 52, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 1, 0, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 9, 44, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 19, 21, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 1, 26, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 23, 20, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 21, 27, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 23, 5, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 10, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 4, 44, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 4, 9, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 3, 26, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 14, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 20, 7, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 615,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 13, 35, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 0, 22, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 44, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 7, 36, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 1, 5, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 15, 4, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 20, 31, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 6, 24, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 7, 44, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 4, 19, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 15, 44, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 22, 41, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 16, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 19, 53, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 19, 54, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 16, 25, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 17, 56, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 9, 17, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 8, 24, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 15, 5, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 22, 31, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 5, 6, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 12, 19, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 2, 26, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 6, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 5, 54, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 5, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 2, 54, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 10, 30, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 4, 59, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 17, 28, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 20, 9, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 0, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 12, 41, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 632,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 12, 5, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 7, 2, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 21, 47, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 0, 59, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 3, 38, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 9, 10, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 12, 1, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 8, 29, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 19, 25, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 23, 29, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 1, 22, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 13, 12, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 5, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 14, 21, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 19, 43, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 11, 7, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 1, 11, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 14, 36, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 6, 27, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 15, 28, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 1, 43, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 22, 53, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 23, 17, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 21, 29, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 14, 26, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 20, 50, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 25, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 14, 55, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 19, 57, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 7, 34, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 16, 46, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 19, 16, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 11, 39, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 8, 16, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 18, 13, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 23, 29, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 20, 52, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 7, 25, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 19, 49, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 18, 29, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 17, 23, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 18, 51, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 13, 24, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 18, 55, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 16, 35, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 17, 52, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 9, 34, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 19, 47, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 20, 43, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 5, 2, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 4, 37, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 3, 2, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 5, 28, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 2, 7, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 7, 51, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 5, 51, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 6, 35, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 7, 24, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 18, 28, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 10, 45, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 3, 50, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 14, 10, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 18, 51, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 19, 22, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 40, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 4, 3, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 12, 24, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 8, 16, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 0, 13, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 20, 32, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 12, 28, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 2, 22, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 16, 18, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 12, 31, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 6, 21, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 4, 18, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 1, 13, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 12, 36, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 11, 22, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 4, 34, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 3, 19, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 20, 24, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 17, 49, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 28, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 1, 47, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 1, 19, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 8, 31, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 4, 24, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 17, 45, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 14, 35, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 9, 12, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 5, 12, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 11, 9, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 1, 7, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 14, 2, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 19, 53, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 5, 18, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 5, 26, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 18, 3, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 6, 55, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 15, 21, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 14, 21, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 13, 30, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 24, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 10, 21, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 17, 14, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 1, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 21, 46, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 0, 12, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 3, 9, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 15, 50, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 10, 2, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 4, 32, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 14, 9, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 12, 20, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 39, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 17, 29, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 10, 25, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 8, 35, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 41, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 1, 18, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 7, 0, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 21, 25, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 22, 21, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 13, 26, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 4, 48, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 17, 40, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 16, 24, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 4, 4, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 51, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 0, 32, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 6, 43, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 22, 20, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 18, 59, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 21, 34, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 1, 39, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 18, 7, 59, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 1, 51, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 11, 10, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 12, 43, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 45, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 22, 23, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 18, 38, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 21, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 11, 12, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 23, 47, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 10, 22, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 10, 0, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 21, 59, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 54, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 17, 45, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 22, 3, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 0, 14, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 15, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 6, 37, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 0, 25, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 4, 57, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 21, 18, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 7, 46, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 8, 56, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 14, 32, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 12, 30, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 5, 21, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 714,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 21, 40, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 7, 0, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 6, 16, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 17, 43, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 24, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 6, 50, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 2, 1, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 17, 24, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 49, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 17, 53, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 9, 38, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 22, 26, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 21, 6, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 16, 22, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 20, 35, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 4, 41, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 12, 46, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 22, 32, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 18, 0, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 20, 27, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 51, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 13, 19, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 725,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 23, 27, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 9, 28, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 6, 16, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 19, 24, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 19, 16, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 13, 32, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 12, 24, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 2, 5, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 21, 43, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 19, 19, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 23, 42, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 14, 58, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 12, 58, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 5, 9, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 35, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 18, 27, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 12, 48, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 9, 51, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 23, 1, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 9, 11, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 18, 18, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 11, 19, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 15, 45, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 22, 51, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 20, 7, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 19, 54, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 5, 46, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 8, 50, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 19, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 12, 21, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 17, 14, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 19, 38, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 14, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 16, 8, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 42, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 22, 9, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 45, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 9, 16, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 15, 35, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 12, 40, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 5, 42, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 7, 19, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 17, 5, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 14, 1, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 1, 11, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 10, 44, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 3, 29, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 13, 19, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 20, 6, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 4, 33, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 19, 19, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 0, 4, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 11, 20, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 7, 20, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 13, 46, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 12, 9, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 14, 41, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 21, 59, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 56, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 15, 47, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 32, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 10, 31, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 36, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 1, 0, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 13, 39, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 4, 24, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 23, 29, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 9, 56, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 23, 31, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 4, 15, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 4, 8, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 16, 19, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 32, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 8, 58, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 22, 43, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 23, 38, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 53, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 7, 43, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 6, 59, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 4, 12, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 31, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 20, 15, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 13, 41, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 19, 17, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 4, 52, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 3, 52, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 15, 4, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 0, 27, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 11, 36, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 21, 35, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 39, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 12, 1, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 4, 43, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 15, 39, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 22, 7, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 18, 39, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 6, 34, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 7, 27, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 5, 54, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 11, 19, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 1, 39, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 11, 32, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 11, 52, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 2, 37, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 777,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 14, 9, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 11, 46, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 0, 56, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 7, 6, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 2, 12, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 13, 47, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 15, 29, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 20, 5, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 21, 23, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 11, 58, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 15, 56, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 0, 56, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 2, 38, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 0, 29, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 784,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 1, 23, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 18, 7, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 5, 45, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 21, 4, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 6, 59, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 2, 30, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 21, 22, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 17, 47, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 12, 2, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 8, 31, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 2, 24, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 10, 32, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 14, 13, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 52, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 13, 51, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 0, 18, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 10, 48, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 13, 42, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 15, 4, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 15, 34, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 21, 57, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 15, 55, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 22, 24, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 7, 52, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 15, 3, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 44, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 14, 20, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 14, 52, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 19, 59, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 17, 22, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 10, 54, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 57, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 21, 35, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 20, 16, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 4, 6, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 10, 45, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 23, 3, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 8, 35, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 4, 9, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 19, 54, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 21, 17, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 17, 14, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 22, 36, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 1, 50, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 4, 7, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 6, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 8, 32, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 5, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 9, 59, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 20, 1, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 6, 27, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 20, 48, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 8, 52, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 2, 38, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 23, 9, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 8, 31, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 1, 38, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 12, 44, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 0, 36, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 23, 0, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 20, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 15, 8, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 15, 58, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 13, 51, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 16, 44, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 18, 55, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 18, 52, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 10, 25, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 5, 5, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 1, 19, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 20, 31, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 14, 54, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 0, 56, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 5, 22, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 20, 52, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 6, 36, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 5, 36, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 14, 46, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 16, 3, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 0, 33, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 15, 22, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 19, 7, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 13, 32, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 57, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 23, 45, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 12, 12, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 3, 2, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 12, 8, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 4, 27, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 18, 11, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 3, 28, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 21, 54, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 5, 35, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 6, 51, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 7, 22, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 832,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 53, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 3, 47, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 22, 9, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 18, 28, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 1, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 23, 39, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 2, 29, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 9, 3, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 4, 56, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 16, 38, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 14, 25, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 4, 51, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 8, 49, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 6, 42, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 4, 41, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 17, 12, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 22, 35, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 19, 32, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 20, 14, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 14, 41, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 8, 21, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 17, 1, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 18, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 21, 4, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 4, 10, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 3, 34, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 6, 4, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 17, 54, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 23, 45, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 9, 3, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 55, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 6, 34, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 2, 46, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 6, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 21, 48, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 21, 49, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 9, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 23, 7, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 13, 54, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 14, 7, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 7, 39, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 11, 55, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 9, 48, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 20, 45, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 14, 56, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 8, 13, 26, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 6, 5, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 22, 11, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 5, 20, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 1, 28, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 27, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 13, 26, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 10, 55, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 0, 31, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 15, 56, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 12, 13, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 1, 6, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 18, 12, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 5, 50, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 17, 51, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 7, 53, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 17, 36, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 0, 46, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 23, 12, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 17, 30, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 0, 9, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 1, 43, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 3, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 21, 44, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 10, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 22, 45, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 12, 47, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 19, 50, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 18, 45, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 14, 41, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 15, 56, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 11, 52, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 10, 28, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 1, 27, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 11, 21, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 872,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 13, 5, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 2, 51, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 23, 50, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 2, 34, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 2, 18, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 5, 13, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 38, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 21, 18, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 15, 29, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 3, 5, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 2, 25, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 11, 7, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 22, 22, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 12, 22, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 16, 14, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 11, 54, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 1, 21, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 16, 11, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 7, 19, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 7, 26, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 18, 58, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 14, 29, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 26, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 22, 24, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 33, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 16, 44, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 58, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 22, 39, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 21, 8, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 22, 5, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 13, 48, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 4, 57, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 13, 8, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 12, 47, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 22, 36, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 14, 44, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 13, 28, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 8, 27, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 19, 9, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 23, 39, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 17, 44, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 2, 56, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 19, 52, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 5, 38, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 11, 53, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 8, 49, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 19, 18, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 2, 37, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 22, 29, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 22, 55, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 21, 57, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 14, 36, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 898,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 7, 35, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 15, 20, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 6, 2, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 1, 1, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 9, 1, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 8, 10, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 10, 4, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 23, 12, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 0, 46, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 16, 43, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 17, 2, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 12, 47, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 3, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 6, 57, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 11, 54, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 6, 13, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 13, 50, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 1, 13, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 11, 18, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 12, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 6, 52, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 18, 7, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 15, 18, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 0, 37, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 40, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 3, 23, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 40, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 19, 11, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 17, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 10, 20, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 2, 20, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 5, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 19, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 1, 2, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 16, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 20, 14, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 18, 22, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 23, 3, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 11, 44, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 20, 8, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 9, 19, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 9, 26, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 3, 48, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 6, 22, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 12, 3, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 16, 49, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 5, 28, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 4, 47, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 10, 32, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 17, 38, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 5, 21, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 13, 59, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 46, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 7, 31, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 30, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 6, 11, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 10, 26, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 6, 59, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 4, 21, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 10, 31, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 14, 1, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 11, 43, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 19, 33, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 17, 36, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 14, 32, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 11, 0, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 11, 15, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 1, 35, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 10, 42, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 1, 3, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 13, 28, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 19, 46, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 3, 53, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 19, 17, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 17, 45, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 2, 5, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 20, 17, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 11, 36, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 4, 8, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 5, 47, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 17, 6, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 3, 28, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 22, 6, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 23, 50, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 17, 23, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 0, 30, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 21, 21, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 12, 46, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 12, 13, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 19, 3, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 14, 35, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 14, 38, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 11, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 3, 58, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 945,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 8, 0, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 2, 15, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 7, 41, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 4, 52, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 0, 40, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 10, 20, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 17, 45, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 2, 12, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 22, 39, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 22, 38, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 8, 4, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 5, 41, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 13, 9, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 1, 20, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 4, 24, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 10, 47, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 13, 44, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 0, 15, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 15, 52, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 5, 48, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 10, 22, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 7, 6, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 13, 21, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 22, 45, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 12, 3, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 14, 55, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 3, 18, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 23, 55, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 21, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 6, 9, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 2, 56, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 17, 17, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 10, 51, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 3, 54, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 14, 36, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 23, 22, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 3, 52, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 15, 19, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 6, 33, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 3, 39, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 33, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 10, 16, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 13, 30, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 12, 41, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 57, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 10, 48, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 19, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 12, 32, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 23, 45, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 9, 18, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 0, 30, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 3, 13, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 21, 39, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 1, 45, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 16, 37, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 8, 33, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 13, 20, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 17, 42, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 1, 1, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 20, 35, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 39, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 32, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 23, 57, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 19, 13, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 11, 58, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 12, 28, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 9, 52, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 16, 8, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 8, 9, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 11, 37, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 21, 8, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 20, 26, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 34, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 11, 57, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 13, 0, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 4, 26, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 40, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 16, 31, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 19, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 10, 22, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 21, 41, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 8, 54, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 17, 45, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 1, 1, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 3, 30, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 11, 46, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 23, 51, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 11, 44, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 2, 3, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 18, 4, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 11, 3, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 4, 15, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 18, 29, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 21, 33, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 15, 42, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 20, 33, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 6, 2, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 11, 28, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 12, 59, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 11, 57, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 14, 21, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 15, 41, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 40, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 11, 58, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 4, 9, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 6, 10, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 2, 51, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 12, 14, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 5, 30, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 4, 59, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 8, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 16, 35, 1, 0, DateTimeKind.Unspecified) });
        }
    }
}
