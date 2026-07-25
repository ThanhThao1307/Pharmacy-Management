using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy_Nhom1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBatchNumberSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2026, 7, 17, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 1L,
                column: "BatchNumber",
                value: "LOT-2406-01");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 2L,
                column: "BatchNumber",
                value: "LOT-2406-02");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 3L,
                column: "BatchNumber",
                value: "LOT-2406-03");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 4L,
                column: "BatchNumber",
                value: "LOT-2406-04");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 5L,
                column: "BatchNumber",
                value: "LOT-2407-01");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 6L,
                column: "BatchNumber",
                value: "LOT-2407-02");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 7L,
                column: "BatchNumber",
                value: "LOT-2407-03");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 8L,
                column: "BatchNumber",
                value: "LOT-2407-04");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 9L,
                column: "BatchNumber",
                value: "LOT-2407-05");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 10L,
                column: "BatchNumber",
                value: "LOT-2407-06");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 11L,
                column: "BatchNumber",
                value: "LOT-2407-07");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 12L,
                column: "BatchNumber",
                value: "LOT-2407-08");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 13L,
                column: "BatchNumber",
                value: "LOT-2407-09");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 14L,
                column: "BatchNumber",
                value: "LOT-2407-10");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 15L,
                column: "BatchNumber",
                value: "LOT-2407-11");

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 1L,
                column: "ImportDate",
                value: new DateTime(2026, 6, 17, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 2L,
                column: "ImportDate",
                value: new DateTime(2026, 7, 2, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 3L,
                column: "ImportDate",
                value: new DateTime(2026, 7, 12, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 4L,
                column: "ImportDate",
                value: new DateTime(2026, 7, 16, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 7, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 12, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 15, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 16, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5L,
                column: "OrderDate",
                value: new DateTime(2026, 7, 17, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 1L,
                column: "UploadDate",
                value: new DateTime(2026, 7, 7, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 2L,
                column: "UploadDate",
                value: new DateTime(2026, 7, 7, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 3L,
                column: "UploadDate",
                value: new DateTime(2026, 6, 22, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 4L,
                column: "UploadDate",
                value: new DateTime(2026, 7, 15, 18, 39, 36, 423, DateTimeKind.Local).AddTicks(1540));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "BatchNumber",
                value: "LOT-AMX-26A");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 2L,
                column: "BatchNumber",
                value: "LOT-NEX-01");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 3L,
                column: "BatchNumber",
                value: "LOT-PANA-X");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 4L,
                column: "BatchNumber",
                value: "LOT-ENVC");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 5L,
                column: "BatchNumber",
                value: "LOT-EUGI");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 6L,
                column: "BatchNumber",
                value: "LOT-PHOS-SAPDATE");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 7L,
                column: "BatchNumber",
                value: "LOT-PROP");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 8L,
                column: "BatchNumber",
                value: "LOT-AMLO");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 9L,
                column: "BatchNumber",
                value: "LOT-COVE");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 10L,
                column: "BatchNumber",
                value: "LOT-DERM");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 11L,
                column: "BatchNumber",
                value: "LOT-AUG-NEW");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 12L,
                column: "BatchNumber",
                value: "LOT-CEF");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 13L,
                column: "BatchNumber",
                value: "LOT-EFF-SUY");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 14L,
                column: "BatchNumber",
                value: "LOT-SKIN");

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 15L,
                column: "BatchNumber",
                value: "LOT-BERO");

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
        }
    }
}
