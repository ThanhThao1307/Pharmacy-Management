using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy_Nhom1.Migrations
{
    /// <inheritdoc />
    public partial class AddImportPriceToProductUnit_Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ImportPrice",
                table: "ProductUnits",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1L,
                columns: new[] { "BirthDate", "CreatedDate", "Gender" },
                values: new object[] { null, new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5476), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2L,
                columns: new[] { "BirthDate", "CreatedDate", "Gender" },
                values: new object[] { null, new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5506), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3L,
                columns: new[] { "BirthDate", "CreatedDate", "Gender" },
                values: new object[] { null, new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5508), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4L,
                columns: new[] { "BirthDate", "CreatedDate", "Gender" },
                values: new object[] { null, new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5510), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5L,
                columns: new[] { "BirthDate", "CreatedDate", "Gender" },
                values: new object[] { null, new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5512), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6L,
                columns: new[] { "BirthDate", "CreatedDate", "Gender" },
                values: new object[] { null, new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5514), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7L,
                columns: new[] { "BirthDate", "CreatedDate", "Gender" },
                values: new object[] { null, new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5516), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8L,
                columns: new[] { "BirthDate", "CreatedDate", "Gender" },
                values: new object[] { null, new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5518), null });

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
                columns: new[] { "CreatedBy", "ImportDate" },
                values: new object[] { "Dược sĩ Lê Minh Tâm (Chủ tiệm)", new DateTime(2026, 6, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "ImportDate" },
                values: new object[] { "Dược sĩ Trần Thị Thu", new DateTime(2026, 7, 1, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "ImportDate" },
                values: new object[] { "Dược sĩ Vũ Hoàng Hải", new DateTime(2026, 7, 11, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "ImportDate" },
                values: new object[] { "Dược sĩ Lê Minh Tâm (Chủ tiệm)", new DateTime(2026, 7, 15, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5658) });

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
                columns: new[] { "OrderDate", "UserId" },
                values: new object[] { new DateTime(2026, 7, 15, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5784), 1L });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5L,
                columns: new[] { "OrderDate", "UserId" },
                values: new object[] { new DateTime(2026, 7, 16, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5786), 1L });

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 1L,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "toa_daday.png", new DateTime(2026, 7, 6, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 2L,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "toa_dalieu.png", new DateTime(2026, 7, 6, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 3L,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "toa_huyetap.png", new DateTime(2026, 6, 21, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 4L,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "toa_khangsinh.png", new DateTime(2026, 7, 14, 2, 22, 31, 962, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 1L,
                column: "ImportPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 2L,
                column: "ImportPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 3L,
                column: "ImportPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 4L,
                column: "ImportPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 5L,
                column: "ImportPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductUnits",
                keyColumn: "ProductUnitId",
                keyValue: 6L,
                column: "ImportPrice",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Kháng sinh phổ rộng nhóm Penicillin, chỉ định điều trị các nhiễm khuẩn đường hô hấp trên và dưới, viêm tai giữa, nhiễm khuẩn da và đường tiết niệu.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Kháng sinh kết hợp Amoxicillin và Acid Clavulanic, vượt qua đề kháng của vi khuẩn, trị nhiễm khuẩn nặng tai mũi họng và viêm phế quản.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Kháng sinh Cephalosporin thế hệ 3, điều trị hiệu quả các nhiễm khuẩn đường tiết niệu, viêm phổi, viêm phế quản cấp và mạn tính.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Thuốc ức chế bơm proton (Esomeprazole), chỉ định điều trị trào ngược dạ dày thực quản (GERD), chữa lành và phòng ngừa viêm loét thực quản.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Thuốc kháng acid dạng hỗn dịch hỗ trợ làm dịu nhanh cơn đau dạ dày, giảm ợ chua, ợ nóng do thừa acid dịch vị.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Thuốc chẹn kênh Canxi (Amlodipine), chỉ định trong kiểm soát huyết áp cao mạn tính và điều trị dự phòng cơn đau thắt ngực.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Thuốc phối hợp Amlodipine và Perindopril, kiểm soát huyết áp kép hiệu quả cho bệnh nhân tăng huyết áp vô căn.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Thuốc giảm đau, hạ sốt chứa Paracetamol kết hợp Caffeine giúp tăng cường hiệu quả giảm đau đầu, đau cơ, sốt.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Viên sủi Paracetamol 500mg hòa tan nhanh, giảm đau và hạ sốt nhanh chóng, tiện lợi cho người khó nuốt viên nén.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Siro thảo dược chiết xuất từ lá thường xuân, có tác dụng long đờm, chống co thắt phế quản, làm dịu cơn ho hiệu quả.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Viên nang mềm kết hợp các tinh dầu thảo dược thiên nhiên (Eucalyptol, Menthol, Gừng, Tần), giúp ấm đường hô hấp, giảm ho khan.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Kem bôi da chứa Clobetasol Propionate (Corticoid mạnh), điều trị các bệnh viêm da cơ địa dai dẳng, chàm (Eczema), vẩy nến.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Gel bôi chứa Azelaic Acid 15%, chuyên trị mụn trứng cá, giảm sưng viêm đỏ, bạt sừng và ngăn ngừa sẹo thâm sau mụn.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Viên uống bổ sung Vitamin C và các Vitamin nhóm B (B1, B2, B6, B12), tăng sức đề kháng và phục hồi sức khỏe sau ốm.", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15L,
                columns: new[] { "Description", "ImageFile" },
                values: new object[] { "Viên sủi chứa hàm lượng cao Vitamin C, B và các khoáng chất (Canxi, Magie, Kẽm), giúp khôi phục năng lượng cho cơ thể.", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImportPrice",
                table: "ProductUnits");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 1L,
                column: "ExpiryDate",
                value: new DateTime(2028, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 2L,
                column: "ExpiryDate",
                value: new DateTime(2027, 8, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 3L,
                column: "ExpiryDate",
                value: new DateTime(2029, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 4L,
                column: "ExpiryDate",
                value: new DateTime(2027, 5, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 5L,
                column: "ExpiryDate",
                value: new DateTime(2027, 12, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 6L,
                column: "ExpiryDate",
                value: new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 7L,
                column: "ExpiryDate",
                value: new DateTime(2027, 2, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 8L,
                column: "ExpiryDate",
                value: new DateTime(2028, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 9L,
                column: "ExpiryDate",
                value: new DateTime(2027, 10, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 10L,
                column: "ExpiryDate",
                value: new DateTime(2027, 4, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 11L,
                column: "ExpiryDate",
                value: new DateTime(2027, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 12L,
                column: "ExpiryDate",
                value: new DateTime(2028, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 13L,
                column: "ExpiryDate",
                value: new DateTime(2029, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 14L,
                column: "ExpiryDate",
                value: new DateTime(2028, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "ImportDetails",
                keyColumn: "ImportDetailId",
                keyValue: 15L,
                column: "ExpiryDate",
                value: new DateTime(2028, 6, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 1L,
                columns: new[] { "CreatedBy", "ImportDate" },
                values: new object[] { "admin", new DateTime(2026, 5, 21, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 2L,
                columns: new[] { "CreatedBy", "ImportDate" },
                values: new object[] { "admin", new DateTime(2026, 6, 5, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 3L,
                columns: new[] { "CreatedBy", "ImportDate" },
                values: new object[] { "admin", new DateTime(2026, 6, 15, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Imports",
                keyColumn: "ImportId",
                keyValue: 4L,
                columns: new[] { "CreatedBy", "ImportDate" },
                values: new object[] { "admin", new DateTime(2026, 6, 19, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1L,
                column: "OrderDate",
                value: new DateTime(2026, 6, 10, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2L,
                column: "OrderDate",
                value: new DateTime(2026, 6, 15, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3L,
                column: "OrderDate",
                value: new DateTime(2026, 6, 18, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4L,
                columns: new[] { "OrderDate", "UserId" },
                values: new object[] { new DateTime(2026, 6, 19, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1072), 3L });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5L,
                columns: new[] { "OrderDate", "UserId" },
                values: new object[] { new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1074), 2L });

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 1L,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "D:/ToaThuoc/hung_daday.png", new DateTime(2026, 6, 10, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 2L,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "D:/ToaThuoc/hung_dalieu.png", new DateTime(2026, 6, 10, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 3L,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "D:/ToaThuoc/thao_huyetap.png", new DateTime(2026, 5, 26, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "PrescriptionFiles",
                keyColumn: "PrescriptionFileId",
                keyValue: 4L,
                columns: new[] { "FilePath", "UploadDate" },
                values: new object[] { "D:/ToaThuoc/minh_khangsinh.png", new DateTime(2026, 6, 18, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1045) });
        }
    }
}
