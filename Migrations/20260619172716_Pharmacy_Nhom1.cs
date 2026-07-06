using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pharmacy_Nhom1.Migrations
{
    /// <inheritdoc />
    public partial class Pharmacy_Nhom1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CategoryCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalSpent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoyaltyPoints = table.Column<int>(type: "int", nullable: false),
                    CustomerGroup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionFiles",
                columns: table => new
                {
                    PrescriptionFileId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionFiles", x => x.PrescriptionFileId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NormalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrescriptionRequired = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imports",
                columns: table => new
                {
                    ImportId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImportCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupplierId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imports", x => x.ImportId);
                    table.ForeignKey(
                        name: "FK_Imports_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnits",
                columns: table => new
                {
                    ProductUnitId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConversionRate = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnits", x => x.ProductUnitId);
                    table.ForeignKey(
                        name: "FK_ProductUnits_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    PrescriptionFileId = table.Column<long>(type: "bigint", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Orders_PrescriptionFiles_PrescriptionFileId",
                        column: x => x.PrescriptionFileId,
                        principalTable: "PrescriptionFiles",
                        principalColumn: "PrescriptionFileId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImportDetails",
                columns: table => new
                {
                    ImportDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImportId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    BatchNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginalQuantity = table.Column<int>(type: "int", nullable: false),
                    CurrentQuantity = table.Column<int>(type: "int", nullable: false),
                    ImportPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportDetails", x => x.ImportDetailId);
                    table.ForeignKey(
                        name: "FK_ImportDetails_Imports_ImportId",
                        column: x => x.ImportId,
                        principalTable: "Imports",
                        principalColumn: "ImportId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImportDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    ImportDetailId = table.Column<long>(type: "bigint", nullable: false),
                    SoldUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConversionRate = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ImportDetails_ImportDetailId",
                        column: x => x.ImportDetailId,
                        principalTable: "ImportDetails",
                        principalColumn: "ImportDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryCode", "CategoryName", "Description", "Status" },
                values: new object[,]
                {
                    { 1, "K_SINH", "Thuốc kháng sinh", "Kháng sinh trị nhiễm khuẩn, bắt buộc có đơn thuốc", true },
                    { 2, "D_DAY", "Thuốc dạ dày - Tiêu hóa", "Hỗ trợ và điều trị viêm loét, trào ngược dạ dày", true },
                    { 3, "T_MACH", "Thuốc tim mạch - Huyết áp", "Thuốc tim mạch, hạ huyết áp mạn tính", true },
                    { 4, "G_DAU", "Thuốc giảm đau - Hạ sốt", "Thuốc giảm đau thông thường và kháng viêm", true },
                    { 5, "H_HAP", "Thuốc ho - Hô hấp", "Siro ho, thuốc long đờm, trị hen suyễn", true },
                    { 6, "D_LIEU", "Thuốc da liễu - Bôi ngoài", "Kem bôi da, trị nấm, mụn nhọt, dị ứng", true },
                    { 7, "TP_CN", "Vitamin & Thực phẩm chức năng", "Sản phẩm bổ sung, nâng cao sức đề kháng", true }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CreatedDate", "CustomerCode", "CustomerGroup", "Email", "FullName", "IsActive", "LoyaltyPoints", "Phone", "TotalSpent" },
                values: new object[,]
                {
                    { 1L, "12 Vườn Lài, Tân Phú, TP.HCM", new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(848), "KH001", "Thường", null, "Trần Văn Hùng", true, 15, "0908123456", 158000m },
                    { 2L, "456 CMT8, Quận 3, TP.HCM", new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(867), "KH002", "Thân thiết", null, "Lê Thị Thảo", true, 125, "0917654321", 1250000m },
                    { 3L, "78 Điện Biên Phủ, Bình Thạnh", new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(870), "KH003", "Vip", null, "Nguyễn Hoàng Minh", true, 460, "0983112233", 4600000m },
                    { 4L, "22 Lý Thường Kiệt, Tân Bình", new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(872), "KH004", "Thường", null, "Phạm Minh Tuấn", true, 8, "0977889900", 85000m },
                    { 5L, "105 Nguyễn Trãi, Quận 5", new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(873), "KH005", "Thân thiết", null, "Hoàng Ngọc Mai", true, 210, "0934556677", 2100000m },
                    { 6L, "66 Lê Văn Sỹ, Phú Nhuận", new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(875), "KH006", "Thường", null, "Vũ Đình Toàn", true, 0, "0909998877", 0m },
                    { 7L, "19 Đường số 4, Gò Vấp", new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(878), "KH007", "Thường", null, "Đỗ Thuý Hạnh", true, 12, "0918223344", 124000m },
                    { 8L, "312 Nguyễn Thị Minh Khai, Q1", new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(879), "KH008", "Vip", null, "Bùi Quốc Anh", true, 520, "0965443322", 5200000m }
                });

            migrationBuilder.InsertData(
                table: "PrescriptionFiles",
                columns: new[] { "PrescriptionFileId", "FileName", "FilePath", "Note", "Status", "UploadDate" },
                values: new object[,]
                {
                    { 1L, "TOA_LOET_DADAY_HUNG.png", "D:/ToaThuoc/hung_daday.png", "Toa thuốc dạ dày - BV Đại học Y Dược", true, new DateTime(2026, 6, 10, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1041) },
                    { 2L, "TOA_VIEMDA_HUNG.png", "D:/ToaThuoc/hung_dalieu.png", "Toa bôi da liễu - Bệnh viện Da Liễu", true, new DateTime(2026, 6, 10, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1042) },
                    { 3L, "TOA_HUYETAP_THAO.png", "D:/ToaThuoc/thao_huyetap.png", "Đơn thuốc huyết áp vô căn mãn tính", true, new DateTime(2026, 5, 26, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1044) },
                    { 4L, "TOA_K_SINH_MINH.png", "D:/ToaThuoc/minh_khangsinh.png", "Toa kháng sinh trị viêm tai giữa", true, new DateTime(2026, 6, 18, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1045) }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "Email", "Phone", "Status", "SupplierName", "TaxCode" },
                values: new object[,]
                {
                    { 1L, "288 Nguyễn Văn Cừ, Cần Thơ", null, "02923891433", true, "Công ty Cổ phần Dược Hậu Giang (DHG)", "1800156891" },
                    { 2L, "1017 Hồng Bàng, Quận 6, TP.HCM", null, "02837517111", true, "Công ty Cổ phần Dược phẩm OPC", "0302512345" },
                    { 3L, "75 Yên Ninh, Ba Đình, Hà Nội", null, "18006612", true, "Công ty Cổ phần Traphaco", "0100108656" },
                    { 4L, "Khu công nghệ cao, Quận 9, TP.HCM", null, "02838298526", true, "Dược phẩm Sanofi Việt Nam", "0300624512" },
                    { 5L, "Lầu 11, Saigon Trade Center, Quận 1, TP.HCM", null, "02839102626", true, "Nhà thuốc phân phối sỉ Zuellig Pharma", "0301460351" }
                });

            migrationBuilder.InsertData(
                table: "Imports",
                columns: new[] { "ImportId", "CreatedBy", "ImportCode", "ImportDate", "Status", "SupplierId", "TotalAmount" },
                values: new object[,]
                {
                    { 1L, "admin", "HDN_001", new DateTime(2026, 5, 21, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(962), (byte)1, 1L, 5100000m },
                    { 2L, "admin", "HDN_002", new DateTime(2026, 6, 5, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(967), (byte)1, 3L, 3250000m },
                    { 3L, "admin", "HDN_003", new DateTime(2026, 6, 15, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(969), (byte)1, 4L, 8400000m },
                    { 4L, "admin", "HDN_004", new DateTime(2026, 6, 19, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(971), (byte)1, 5L, 2900000m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "NormalPrice", "PrescriptionRequired", "Price", "ProductCode", "ProductName", "Status", "Unit" },
                values: new object[,]
                {
                    { 1L, 1, null, true, 2500m, "AMX500", "Amoxicillin 500mg", true, "Viên" },
                    { 2L, 1, null, true, 16000m, "AUG625", "Augmentin 625mg", true, "Viên" },
                    { 3L, 1, null, true, 4500m, "CEF200", "Cefixim 200mg", true, "Viên" },
                    { 4L, 2, null, true, 24000m, "NEX40", "Nexium Mups 40mg", true, "Viên" },
                    { 5L, 2, null, false, 4800m, "PHOS", "Phosphalugel", true, "Gói" },
                    { 6L, 3, null, true, 9200m, "AMLO5", "Amlor 5mg", true, "Viên" },
                    { 7L, 3, null, true, 11500m, "COVE", "Coveram 5mg/5mg", true, "Viên" },
                    { 8L, 4, null, false, 1500m, "PANA_EX", "Panadol Extra", true, "Viên" },
                    { 9L, 4, null, false, 2900m, "EFF500", "Efferalgan Sủi 500mg", true, "Viên" },
                    { 10L, 5, null, false, 82000m, "PROS", "Siro Ho Prospan 100ml", true, "Chai" },
                    { 11L, 5, null, false, 1000m, "EXPEC", "Eugica Đỏ", true, "Viên" },
                    { 12L, 6, null, true, 90000m, "DERMA", "Dermovate Cream 15g", true, "Tuýp" },
                    { 13L, 6, null, false, 320000m, "SKIN", "Skinoren Gel 30g", true, "Tuýp" },
                    { 14L, 7, null, false, 1500m, "ENVC", "Vitamin C Enervon", true, "Viên" },
                    { 15L, 7, null, false, 8500m, "BERO", "Berocca Viên Sủi Bổ Sung", true, "Viên" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FullName", "IsActive", "PasswordHash", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1L, "Dược sĩ Lê Minh Tâm (Chủ tiệm)", true, "admin123", 1, "admin" },
                    { 2L, "Dược sĩ Trần Thị Thu", true, "thu123", 2, "ds_thu" },
                    { 3L, "Dược sĩ Vũ Hoàng Hải", true, "hai123", 2, "ds_hai" }
                });

            migrationBuilder.InsertData(
                table: "ImportDetails",
                columns: new[] { "ImportDetailId", "BatchNumber", "CurrentQuantity", "ExpiryDate", "ImportId", "ImportPrice", "OriginalQuantity", "ProductId" },
                values: new object[,]
                {
                    { 1L, "LOT-AMX-26A", 450, new DateTime(2028, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 1L, 1500m, 2000, 1L },
                    { 2L, "LOT-NEX-01", 15, new DateTime(2027, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), 1L, 17500m, 200, 4L },
                    { 3L, "LOT-PANA-X", 300, new DateTime(2029, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 1L, 1000m, 1500, 8L },
                    { 4L, "LOT-ENVC", 8, new DateTime(2027, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), 1L, 58000m, 50, 14L },
                    { 5L, "LOT-EUGI", 220, new DateTime(2027, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), 2L, 720m, 500, 11L },
                    { 6L, "LOT-PHOS-SAPDATE", 120, new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Local), 2L, 3200m, 500, 5L },
                    { 7L, "LOT-PROP", 12, new DateTime(2027, 2, 20, 0, 0, 0, 0, DateTimeKind.Local), 2L, 64000m, 30, 10L },
                    { 8L, "LOT-AMLO", 380, new DateTime(2028, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 3L, 6800m, 500, 6L },
                    { 9L, "LOT-COVE", 260, new DateTime(2027, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 3L, 8500m, 300, 7L },
                    { 10L, "LOT-DERM", 35, new DateTime(2027, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), 3L, 68000m, 40, 12L },
                    { 11L, "LOT-AUG-NEW", 150, new DateTime(2027, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 4L, 13500m, 150, 2L },
                    { 12L, "LOT-CEF", 500, new DateTime(2028, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 4L, 3100m, 500, 3L },
                    { 13L, "LOT-EFF-SUY", 400, new DateTime(2029, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 4L, 2000m, 400, 9L },
                    { 14L, "LOT-SKIN", 10, new DateTime(2028, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 4L, 250000m, 10, 13L },
                    { 15L, "LOT-BERO", 25, new DateTime(2028, 6, 20, 0, 0, 0, 0, DateTimeKind.Local), 4L, 65000m, 25, 15L }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "Discount", "NetAmount", "OrderCode", "OrderDate", "PrescriptionFileId", "Status", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, 0m, 143000m, "HD_001", new DateTime(2026, 6, 10, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1064), 1L, true, 143000m, 2L },
                    { 2L, 2L, 14000m, 400000m, "HD_002", new DateTime(2026, 6, 15, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1067), 3L, false, 414000m, 2L },
                    { 3L, 3L, 0m, 250000m, "HD_003", new DateTime(2026, 6, 18, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1070), 4L, false, 250000m, 3L },
                    { 4L, null, 0m, 222000m, "HD_004", new DateTime(2026, 6, 19, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1072), null, true, 222000m, 3L },
                    { 5L, 7L, 4000m, 120000m, "HD_005", new DateTime(2026, 6, 20, 0, 27, 16, 214, DateTimeKind.Local).AddTicks(1074), null, true, 124000m, 2L }
                });

            migrationBuilder.InsertData(
                table: "ProductUnits",
                columns: new[] { "ProductUnitId", "ConversionRate", "Price", "ProductId", "UnitName" },
                values: new object[,]
                {
                    { 1L, 100, 230000m, 1L, "Hộp" },
                    { 2L, 10, 24000m, 1L, "Vỉ" },
                    { 3L, 14, 210000m, 2L, "Hộp" },
                    { 4L, 10, 14000m, 8L, "Vỉ" },
                    { 5L, 100, 135000m, 8L, "Hộp" },
                    { 6L, 20, 55000m, 9L, "Hộp" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailId", "ConversionRate", "ImportDetailId", "OrderId", "Price", "Quantity", "SoldUnit" },
                values: new object[,]
                {
                    { 1L, 1, 2L, 1L, 24000m, 2, "Viên" },
                    { 2L, 1, 10L, 1L, 90000m, 1, "Tuýp" },
                    { 3L, 1, 6L, 1L, 5000m, 1, "Gói" },
                    { 4L, 1, 8L, 2L, 9200m, 30, "Viên" },
                    { 5L, 1, 9L, 2L, 11500m, 12, "Viên" },
                    { 6L, 14, 11L, 3L, 160000m, 1, "Hộp" },
                    { 7L, 1, 1L, 3L, 2500m, 36, "Viên" },
                    { 8L, 1, 7L, 4L, 82000m, 1, "Chai" },
                    { 9L, 1, 4L, 4L, 78000m, 1, "Viên" },
                    { 10L, 1, 15L, 4L, 62000m, 1, "Viên" },
                    { 11L, 20, 13L, 5L, 58000m, 1, "Hộp" },
                    { 12L, 1, 6L, 5L, 4800m, 10, "Gói" },
                    { 13L, 10, 3L, 5L, 18000m, 1, "Vỉ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImportDetails_ImportId",
                table: "ImportDetails",
                column: "ImportId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportDetails_ProductId",
                table: "ImportDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_SupplierId",
                table: "Imports",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ImportDetailId",
                table: "OrderDetails",
                column: "ImportDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PrescriptionFileId",
                table: "Orders",
                column: "PrescriptionFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnits_ProductId",
                table: "ProductUnits",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductUnits");

            migrationBuilder.DropTable(
                name: "ImportDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Imports");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PrescriptionFiles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
