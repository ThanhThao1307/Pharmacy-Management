using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pharmacy_Nhom1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductUnitSeedData_V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 6L);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 1L,
                column: "ExpiryDate",
                value: new DateTime(2028, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 2L,
                column: "ExpiryDate",
                value: new DateTime(2027, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 3L,
                column: "ExpiryDate",
                value: new DateTime(2029, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 4L,
                column: "ExpiryDate",
                value: new DateTime(2027, 6, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 5L,
                column: "ExpiryDate",
                value: new DateTime(2028, 1, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 6L,
                column: "ExpiryDate",
                value: new DateTime(2026, 8, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 7L,
                column: "ExpiryDate",
                value: new DateTime(2027, 3, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 8L,
                column: "ExpiryDate",
                value: new DateTime(2028, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 9L,
                column: "ExpiryDate",
                value: new DateTime(2027, 11, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 10L,
                column: "ExpiryDate",
                value: new DateTime(2027, 5, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 11L,
                column: "ExpiryDate",
                value: new DateTime(2027, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 12L,
                column: "ExpiryDate",
                value: new DateTime(2028, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 13L,
                column: "ExpiryDate",
                value: new DateTime(2029, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 14L,
                column: "ExpiryDate",
                value: new DateTime(2028, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 15L,
                column: "ExpiryDate",
                value: new DateTime(2028, 7, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 1L,
                column: "ImportDate",
                value: new DateTime(2026, 6, 17, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 2L,
                column: "ImportDate",
                value: new DateTime(2026, 7, 2, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 3L,
                column: "ImportDate",
                value: new DateTime(2026, 7, 12, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 4L,
                column: "ImportDate",
                value: new DateTime(2026, 7, 16, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 7, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 12, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 15, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 16, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 17, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 1L,
                column: "UploadDate",
                value: new DateTime(2026, 7, 7, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 2L,
                column: "UploadDate",
                value: new DateTime(2026, 7, 7, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 3L,
                column: "UploadDate",
                value: new DateTime(2026, 6, 22, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 4L,
                column: "UploadDate",
                value: new DateTime(2026, 7, 15, 16, 34, 36, 510, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.InsertData(
                table: "ProductUnits",
                columns: new[] { "ProductUnitId", "ConversionRate", "ImportPrice", "Price", "ProductId", "UnitName" },
                values: new object[,]
                {
                    { 101L, 10, 20000m, 26000m, 1L, "Vỉ" },
                    { 102L, 100, 180000m, 250000m, 1L, "Hộp" },
                    { 103L, 14, 190000m, 230000m, 2L, "Vỉ" },
                    { 104L, 28, 370000m, 450000m, 2L, "Hộp" },
                    { 105L, 10, 35000m, 47000m, 3L, "Vỉ" },
                    { 106L, 30, 100000m, 135000m, 3L, "Hộp" },
                    { 107L, 14, 280000m, 340000m, 4L, "Vỉ" },
                    { 108L, 28, 550000m, 670000m, 4L, "Hộp" },
                    { 109L, 26, 100000m, 125000m, 5L, "Hộp" },
                    { 110L, 10, 75000m, 95000m, 6L, "Vỉ" },
                    { 111L, 30, 220000m, 275000m, 6L, "Hộp" },
                    { 112L, 30, 280000m, 350000m, 7L, "Vỉ" },
                    { 113L, 30, 280000m, 350000m, 7L, "Hộp" },
                    { 114L, 10, 12000m, 16000m, 8L, "Vỉ" },
                    { 115L, 100, 110000m, 150000m, 8L, "Hộp" },
                    { 116L, 4, 9000m, 12000m, 9L, "Vỉ" },
                    { 117L, 16, 35000m, 45000m, 9L, "Hộp" },
                    { 118L, 50, 3500000m, 4000000m, 10L, "Thùng" },
                    { 119L, 10, 8000m, 11000m, 11L, "Vỉ" },
                    { 120L, 100, 75000m, 105000m, 11L, "Hộp" },
                    { 121L, 1, 80000m, 95000m, 12L, "Hộp" },
                    { 122L, 1, 280000m, 330000m, 13L, "Hộp" },
                    { 123L, 10, 12000m, 16000m, 14L, "Vỉ" },
                    { 124L, 100, 115000m, 155000m, 14L, "Hộp" },
                    { 125L, 10, 70000m, 86000m, 15L, "Tuýp" },
                    { 126L, 20, 135000m, 170000m, 15L, "Hộp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 126L);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 1L,
                column: "ExpiryDate",
                value: new DateTime(2028, 7, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 2L,
                column: "ExpiryDate",
                value: new DateTime(2027, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 3L,
                column: "ExpiryDate",
                value: new DateTime(2029, 7, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 4L,
                column: "ExpiryDate",
                value: new DateTime(2027, 6, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 5L,
                column: "ExpiryDate",
                value: new DateTime(2028, 1, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 6L,
                column: "ExpiryDate",
                value: new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 7L,
                column: "ExpiryDate",
                value: new DateTime(2027, 3, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 8L,
                column: "ExpiryDate",
                value: new DateTime(2028, 7, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 9L,
                column: "ExpiryDate",
                value: new DateTime(2027, 11, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 10L,
                column: "ExpiryDate",
                value: new DateTime(2027, 5, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 11L,
                column: "ExpiryDate",
                value: new DateTime(2027, 7, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 12L,
                column: "ExpiryDate",
                value: new DateTime(2028, 7, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 13L,
                column: "ExpiryDate",
                value: new DateTime(2029, 7, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 14L,
                column: "ExpiryDate",
                value: new DateTime(2028, 7, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 15L,
                column: "ExpiryDate",
                value: new DateTime(2028, 7, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 1L,
                column: "ImportDate",
                value: new DateTime(2026, 6, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 2L,
                column: "ImportDate",
                value: new DateTime(2026, 7, 1, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 3L,
                column: "ImportDate",
                value: new DateTime(2026, 7, 11, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 4L,
                column: "ImportDate",
                value: new DateTime(2026, 7, 15, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 6, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 11, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 14, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 15, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 1L,
                column: "UploadDate",
                value: new DateTime(2026, 7, 6, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 2L,
                column: "UploadDate",
                value: new DateTime(2026, 7, 6, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 3L,
                column: "UploadDate",
                value: new DateTime(2026, 6, 21, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 4L,
                column: "UploadDate",
                value: new DateTime(2026, 7, 14, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.InsertData(
                table: "ProductUnits",
                columns: new[] { "ProductUnitId", "ConversionRate", "ImportPrice", "Price", "ProductId", "UnitName" },
                values: new object[,]
                {
                    { 1L, 100, null, 230000m, 1L, "Hộp" },
                    { 2L, 10, null, 24000m, 1L, "Vỉ" },
                    { 3L, 14, null, 210000m, 2L, "Hộp" },
                    { 4L, 10, null, 14000m, 8L, "Vỉ" },
                    { 5L, 100, null, 135000m, 8L, "Hộp" },
                    { 6L, 20, null, 55000m, 9L, "Hộp" }
                });
        }
    }
}
