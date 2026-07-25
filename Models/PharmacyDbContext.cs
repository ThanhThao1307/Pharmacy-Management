using Microsoft.EntityFrameworkCore;
using System;

namespace Pharmacy_Nhom1.Models
{
    public partial class PharmacyDbContext : DbContext
    {
        public PharmacyDbContext() { }
        public PharmacyDbContext(DbContextOptions<PharmacyDbContext> options) : base(options) { }

        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductUnit> ProductUnits { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Import> Imports { get; set; } = null!;
        public virtual DbSet<ImportDetail> ImportDetails { get; set; } = null!;
        public virtual DbSet<PrescriptionFile> PrescriptionFiles { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. CẤU HÌNH PRODUCTS
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
                entity.Property(e => e.NormalPrice).HasColumnType("decimal(18,2)");
                entity.HasOne(x => x.Category).WithMany(x => x.Products)
                    .HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Restrict);
            });

            // 2. CẤU HÌNH PRODUCT UNITS
            modelBuilder.Entity<ProductUnit>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
                entity.HasOne(x => x.Product).WithMany(x => x.ProductUnits)
                    .HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);
            });

            // 3. CẤU HÌNH CUSTOMERS
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.TotalSpent).HasColumnType("decimal(18,2)");
            });

            // 4. CẤU HÌNH IMPORTS
            modelBuilder.Entity<Import>(entity =>
            {
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Status).HasColumnType("tinyint");
                entity.HasOne(x => x.Supplier).WithMany(x => x.Imports)
                    .HasForeignKey(x => x.SupplierId).OnDelete(DeleteBehavior.Restrict);
            });

            // 5. CẤU HÌNH IMPORT DETAILS
            modelBuilder.Entity<ImportDetail>(entity =>
            {
                entity.Property(e => e.ImportPrice).HasColumnType("decimal(18,2)");
                entity.HasOne(x => x.Import).WithMany(x => x.ImportDetails)
                    .HasForeignKey(x => x.ImportId).OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(x => x.Product).WithMany(x => x.ImportDetails)
                    .HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Restrict);
            });

            // 6. CẤU HÌNH ORDERS
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Discount).HasColumnType("decimal(18,2)");
                entity.Property(e => e.NetAmount).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Status).HasColumnType("bit");
                entity.HasOne(x => x.Customer).WithMany(x => x.Orders)
                    .HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.SetNull);
                entity.HasOne(x => x.User).WithMany(x => x.Orders)
                    .HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(x => x.PrescriptionFile).WithMany()
                    .HasForeignKey(x => x.PrescriptionFileId).OnDelete(DeleteBehavior.SetNull);
            });

            // 7. CẤU HÌNH ORDER DETAILS
            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
                entity.HasOne(x => x.Order).WithMany(x => x.OrderDetails)
                    .HasForeignKey(x => x.OrderId).OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(x => x.ImportDetail).WithMany()
                    .HasForeignKey(x => x.ImportDetailId).OnDelete(DeleteBehavior.Restrict);
            });

            SeedAllData(modelBuilder);
        }

        private void SeedAllData(ModelBuilder modelBuilder)
        {
            // 1. SEED ROLES
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Admin" },
                new Role { RoleId = 2, RoleName = "Employee" }
            );

            // 2. SEED USERS
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "admin", PasswordHash = "admin123", FullName = "Dược sĩ Lê Minh Tâm (Chủ tiệm)", RoleId = 1, IsActive = true },
                new User { UserId = 2, Username = "ds_thu", PasswordHash = "thu123", FullName = "Dược sĩ Trần Thị Thu", RoleId = 2, IsActive = true },
                new User { UserId = 3, Username = "ds_hai", PasswordHash = "hai123", FullName = "Dược sĩ Vũ Hoàng Hải", RoleId = 2, IsActive = true }
            );

            // 3. SEED CATEGORIES
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Thuốc kháng sinh", CategoryCode = "K_SINH", Description = "Kháng sinh trị nhiễm khuẩn, bắt buộc có đơn thuốc", Status = true },
                new Category { CategoryId = 2, CategoryName = "Thuốc dạ dày - Tiêu hóa", CategoryCode = "D_DAY", Description = "Hỗ trợ và điều trị viêm loét, trào ngược dạ dày", Status = true },
                new Category { CategoryId = 3, CategoryName = "Thuốc tim mạch - Huyết áp", CategoryCode = "T_MACH", Description = "Thuốc tim mạch, hạ huyết áp mạn tính", Status = true },
                new Category { CategoryId = 4, CategoryName = "Thuốc giảm đau - Hạ sốt", CategoryCode = "G_DAU", Description = "Thuốc giảm đau thông thường và kháng viêm", Status = true },
                new Category { CategoryId = 5, CategoryName = "Thuốc ho - Hô hấp", CategoryCode = "H_HAP", Description = "Siro ho, thuốc long đờm, trị hen suyễn", Status = true },
                new Category { CategoryId = 6, CategoryName = "Thuốc da liễu - Bôi ngoài", CategoryCode = "D_LIEU", Description = "Kem bôi da, trị nấm, mụn nhọt, dị ứng", Status = true },
                new Category { CategoryId = 7, CategoryName = "Vitamin & Thực phẩm chức năng", CategoryCode = "TP_CN", Description = "Sản phẩm bổ sung, nâng cao sức đề kháng", Status = true }
            );

            // 4. SEED SUPPLIERS
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { SupplierId = 1, SupplierName = "Công ty Cổ phần Dược Hậu Giang (DHG)", Phone = "02923891433", TaxCode = "1800156891", Address = "288 Nguyễn Văn Cừ, Cần Thơ", Status = true },
                new Supplier { SupplierId = 2, SupplierName = "Công ty Cổ phần Dược phẩm OPC", Phone = "02837517111", TaxCode = "0302512345", Address = "1017 Hồng Bàng, Quận 6, TP.HCM", Status = true },
                new Supplier { SupplierId = 3, SupplierName = "Công ty Cổ phần Traphaco", Phone = "18006612", TaxCode = "0100108656", Address = "75 Yên Ninh, Ba Đình, Hà Nội", Status = true },
                new Supplier { SupplierId = 4, SupplierName = "Dược phẩm Sanofi Việt Nam", Phone = "02838298526", TaxCode = "0300624512", Address = "Khu công nghệ cao, Quận 9, TP.HCM", Status = true },
                new Supplier { SupplierId = 5, SupplierName = "Nhà thuốc phân phối sỉ Zuellig Pharma", Phone = "02839102626", TaxCode = "0301460351", Address = "Lầu 11, Saigon Trade Center, Quận 1, TP.HCM", Status = true }
            );

            // 5. SEED CUSTOMERS
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, CustomerCode = "KH001", FullName = "Trần Văn Hùng", Phone = "0908123456", Address = "12 Vườn Lài, Tân Phú, TP.HCM", TotalSpent = 158000, LoyaltyPoints = 15, CustomerGroup = "Thường", IsActive = true },
                new Customer { CustomerId = 2, CustomerCode = "KH002", FullName = "Lê Thị Thảo", Phone = "0917654321", Address = "456 CMT8, Quận 3, TP.HCM", TotalSpent = 1250000, LoyaltyPoints = 125, CustomerGroup = "Thân thiết", IsActive = true },
                new Customer { CustomerId = 3, CustomerCode = "KH003", FullName = "Nguyễn Hoàng Minh", Phone = "0983112233", Address = "78 Điện Biên Phủ, Bình Thạnh", TotalSpent = 4600000, LoyaltyPoints = 460, CustomerGroup = "Vip", IsActive = true },
                new Customer { CustomerId = 4, CustomerCode = "KH004", FullName = "Phạm Minh Tuấn", Phone = "0977889900", Address = "22 Lý Thường Kiệt, Tân Bình", TotalSpent = 85000, LoyaltyPoints = 8, CustomerGroup = "Thường", IsActive = true },
                new Customer { CustomerId = 5, CustomerCode = "KH005", FullName = "Hoàng Ngọc Mai", Phone = "0934556677", Address = "105 Nguyễn Trãi, Quận 5", TotalSpent = 2100000, LoyaltyPoints = 210, CustomerGroup = "Thân thiết", IsActive = true },
                new Customer { CustomerId = 6, CustomerCode = "KH006", FullName = "Vũ Đình Toàn", Phone = "0909998877", Address = "66 Lê Văn Sỹ, Phú Nhuận", TotalSpent = 0, LoyaltyPoints = 0, CustomerGroup = "Thường", IsActive = true },
                new Customer { CustomerId = 7, CustomerCode = "KH007", FullName = "Đỗ Thuý Hạnh", Phone = "0918223344", Address = "19 Đường số 4, Gò Vấp", TotalSpent = 124000, LoyaltyPoints = 12, CustomerGroup = "Thường", IsActive = true },
                new Customer { CustomerId = 8, CustomerCode = "KH008", FullName = "Bùi Quốc Anh", Phone = "0965443322", Address = "312 Nguyễn Thị Minh Khai, Q1", TotalSpent = 5200000, LoyaltyPoints = 520, CustomerGroup = "Vip", IsActive = true }
            );

            // 6. SEED PRODUCTS 
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductCode = "AMX500", ProductName = "Amoxicillin 500mg", CategoryId = 1, Unit = "Viên", Price = 2500, PrescriptionRequired = true, Status = true, Description = "Kháng sinh phổ rộng nhóm Penicillin, chỉ định điều trị các nhiễm khuẩn đường hô hấp trên và dưới, viêm tai giữa, nhiễm khuẩn da và đường tiết niệu." },
                new Product { ProductId = 2, ProductCode = "AUG625", ProductName = "Augmentin 625mg", CategoryId = 1, Unit = "Viên", Price = 16000, PrescriptionRequired = true, Status = true, Description = "Kháng sinh kết hợp Amoxicillin và Acid Clavulanic, vượt qua đề kháng của vi khuẩn, trị nhiễm khuẩn nặng tai mũi họng và viêm phế quản." },
                new Product { ProductId = 3, ProductCode = "CEF200", ProductName = "Cefixim 200mg", CategoryId = 1, Unit = "Viên", Price = 4500, PrescriptionRequired = true, Status = true, Description = "Kháng sinh Cephalosporin thế hệ 3, điều trị hiệu quả các nhiễm khuẩn đường tiết niệu, viêm phổi, viêm phế quản cấp và mạn tính." },
                new Product { ProductId = 4, ProductCode = "NEX40", ProductName = "Nexium Mups 40mg", CategoryId = 2, Unit = "Viên", Price = 24000, PrescriptionRequired = true, Status = true, Description = "Thuốc ức chế bơm proton (Esomeprazole), chỉ định điều trị trào ngược dạ dày thực quản (GERD), chữa lành và phòng ngừa viêm loét thực quản." },
                new Product { ProductId = 5, ProductCode = "PHOS", ProductName = "Phosphalugel", CategoryId = 2, Unit = "Gói", Price = 4800, PrescriptionRequired = false, Status = true, Description = "Thuốc kháng acid dạng hỗn dịch hỗ trợ làm dịu nhanh cơn đau dạ dày, giảm ợ chua, ợ nóng do thừa acid dịch vị." },
                new Product { ProductId = 6, ProductCode = "AMLO5", ProductName = "Amlor 5mg", CategoryId = 3, Unit = "Viên", Price = 9200, PrescriptionRequired = true, Status = true, Description = "Thuốc chẹn kênh Canxi (Amlodipine), chỉ định trong kiểm soát huyết áp cao mạn tính và điều trị dự phòng cơn đau thắt ngực." },
                new Product { ProductId = 7, ProductCode = "COVE", ProductName = "Coveram 5mg/5mg", CategoryId = 3, Unit = "Viên", Price = 11500, PrescriptionRequired = true, Status = true, Description = "Thuốc phối hợp Amlodipine và Perindopril, kiểm soát huyết áp kép hiệu quả cho bệnh nhân tăng huyết áp vô căn." },
                new Product { ProductId = 8, ProductCode = "PANA_EX", ProductName = "Panadol Extra", CategoryId = 4, Unit = "Viên", Price = 1500, PrescriptionRequired = false, Status = true, Description = "Thuốc giảm đau, hạ sốt chứa Paracetamol kết hợp Caffeine giúp tăng cường hiệu quả giảm đau đầu, đau cơ, sốt." },
                new Product { ProductId = 9, ProductCode = "EFF500", ProductName = "Efferalgan Sủi 500mg", CategoryId = 4, Unit = "Viên", Price = 2900, PrescriptionRequired = false, Status = true, Description = "Viên sủi Paracetamol 500mg hòa tan nhanh, giảm đau và hạ sốt nhanh chóng, tiện lợi cho người khó nuốt viên nén." },
                new Product { ProductId = 10, ProductCode = "PROS", ProductName = "Siro Ho Prospan 100ml", CategoryId = 5, Unit = "Chai", Price = 82000, PrescriptionRequired = false, Status = true, Description = "Siro thảo dược chiết xuất từ lá thường xuân, có tác dụng long đờm, chống co thắt phế quản, làm dịu cơn ho hiệu quả." },
                new Product { ProductId = 11, ProductCode = "EXPEC", ProductName = "Eugica Đỏ", CategoryId = 5, Unit = "Viên", Price = 1000, PrescriptionRequired = false, Status = true, Description = "Viên nang mềm kết hợp các tinh dầu thảo dược thiên nhiên (Eucalyptol, Menthol, Gừng, Tần), giúp ấm đường hô hấp, giảm ho khan." },
                new Product { ProductId = 12, ProductCode = "DERMA", ProductName = "Dermovate Cream 15g", CategoryId = 6, Unit = "Tuýp", Price = 90000, PrescriptionRequired = true, Status = true, Description = "Kem bôi da chứa Clobetasol Propionate (Corticoid mạnh), điều trị các bệnh viêm da cơ địa dai dẳng, chàm (Eczema), vẩy nến." },
                new Product { ProductId = 13, ProductCode = "SKIN", ProductName = "Skinoren Gel 30g", CategoryId = 6, Unit = "Tuýp", Price = 320000, PrescriptionRequired = false, Status = true, Description = "Gel bôi chứa Azelaic Acid 15%, chuyên trị mụn trứng cá, giảm sưng viêm đỏ, bạt sừng và ngăn ngừa sẹo thâm sau mụn." },
                new Product { ProductId = 14, ProductCode = "ENVC", ProductName = "Vitamin C Enervon", CategoryId = 7, Unit = "Viên", Price = 1500, PrescriptionRequired = false, Status = true, Description = "Viên uống bổ sung Vitamin C và các Vitamin nhóm B (B1, B2, B6, B12), tăng sức đề kháng và phục hồi sức khỏe sau ốm." },
                new Product { ProductId = 15, ProductCode = "BERO", ProductName = "Berocca Viên Sủi Bổ Sung", CategoryId = 7, Unit = "Viên", Price = 8500, PrescriptionRequired = false, Status = true, Description = "Viên sủi chứa hàm lượng cao Vitamin C, B và các khoáng chất (Canxi, Magie, Kẽm), giúp khôi phục năng lượng cho cơ thể." }
            );

            // 7. SEED PRODUCT UNITS 
            modelBuilder.Entity<ProductUnit>().HasData(
                // 1: AMX500 (Base: Viên)
                new ProductUnit { ProductUnitId = 101, ProductId = 1, UnitName = "Vỉ", ConversionRate = 10, Price = 26000, ImportPrice = 20000 },
                new ProductUnit { ProductUnitId = 102, ProductId = 1, UnitName = "Hộp", ConversionRate = 100, Price = 250000, ImportPrice = 180000 },

                // 2: AUG625 (Base: Viên)
                new ProductUnit { ProductUnitId = 103, ProductId = 2, UnitName = "Vỉ", ConversionRate = 14, Price = 230000, ImportPrice = 190000 },
                new ProductUnit { ProductUnitId = 104, ProductId = 2, UnitName = "Hộp", ConversionRate = 28, Price = 450000, ImportPrice = 370000 },

                // 3: CEF200 (Base: Viên)
                new ProductUnit { ProductUnitId = 105, ProductId = 3, UnitName = "Vỉ", ConversionRate = 10, Price = 47000, ImportPrice = 35000 },
                new ProductUnit { ProductUnitId = 106, ProductId = 3, UnitName = "Hộp", ConversionRate = 30, Price = 135000, ImportPrice = 100000 },

                // 4: NEX40 (Base: Viên)
                new ProductUnit { ProductUnitId = 107, ProductId = 4, UnitName = "Vỉ", ConversionRate = 14, Price = 340000, ImportPrice = 280000 },
                new ProductUnit { ProductUnitId = 108, ProductId = 4, UnitName = "Hộp", ConversionRate = 28, Price = 670000, ImportPrice = 550000 },

                // 5: PHOS (Base: Gói)
                new ProductUnit { ProductUnitId = 109, ProductId = 5, UnitName = "Hộp", ConversionRate = 26, Price = 125000, ImportPrice = 100000 },

                // 6: AMLO5 (Base: Viên)
                new ProductUnit { ProductUnitId = 110, ProductId = 6, UnitName = "Vỉ", ConversionRate = 10, Price = 95000, ImportPrice = 75000 },
                new ProductUnit { ProductUnitId = 111, ProductId = 6, UnitName = "Hộp", ConversionRate = 30, Price = 275000, ImportPrice = 220000 },

                // 7: COVE (Base: Viên)
                new ProductUnit { ProductUnitId = 112, ProductId = 7, UnitName = "Vỉ", ConversionRate = 30, Price = 350000, ImportPrice = 280000 },
                new ProductUnit { ProductUnitId = 113, ProductId = 7, UnitName = "Hộp", ConversionRate = 30, Price = 350000, ImportPrice = 280000 }, // same

                // 8: PANA_EX (Base: Viên)
                new ProductUnit { ProductUnitId = 114, ProductId = 8, UnitName = "Vỉ", ConversionRate = 10, Price = 16000, ImportPrice = 12000 },
                new ProductUnit { ProductUnitId = 115, ProductId = 8, UnitName = "Hộp", ConversionRate = 100, Price = 150000, ImportPrice = 110000 },

                // 9: EFF500 (Base: Viên)
                new ProductUnit { ProductUnitId = 116, ProductId = 9, UnitName = "Vỉ", ConversionRate = 4, Price = 12000, ImportPrice = 9000 },
                new ProductUnit { ProductUnitId = 117, ProductId = 9, UnitName = "Hộp", ConversionRate = 16, Price = 45000, ImportPrice = 35000 },

                // 10: PROS (Base: Chai)
                new ProductUnit { ProductUnitId = 118, ProductId = 10, UnitName = "Thùng", ConversionRate = 50, Price = 4000000, ImportPrice = 3500000 },

                // 11: EXPEC (Base: Viên)
                new ProductUnit { ProductUnitId = 119, ProductId = 11, UnitName = "Vỉ", ConversionRate = 10, Price = 11000, ImportPrice = 8000 },
                new ProductUnit { ProductUnitId = 120, ProductId = 11, UnitName = "Hộp", ConversionRate = 100, Price = 105000, ImportPrice = 75000 },

                // 12: DERMA (Base: Tuýp)
                new ProductUnit { ProductUnitId = 121, ProductId = 12, UnitName = "Hộp", ConversionRate = 1, Price = 95000, ImportPrice = 80000 },

                // 13: SKIN (Base: Tuýp)
                new ProductUnit { ProductUnitId = 122, ProductId = 13, UnitName = "Hộp", ConversionRate = 1, Price = 330000, ImportPrice = 280000 },

                // 14: ENVC (Base: Viên)
                new ProductUnit { ProductUnitId = 123, ProductId = 14, UnitName = "Vỉ", ConversionRate = 10, Price = 16000, ImportPrice = 12000 },
                new ProductUnit { ProductUnitId = 124, ProductId = 14, UnitName = "Hộp", ConversionRate = 100, Price = 155000, ImportPrice = 115000 },

                // 15: BERO (Base: Viên)
                new ProductUnit { ProductUnitId = 125, ProductId = 15, UnitName = "Tuýp", ConversionRate = 10, Price = 86000, ImportPrice = 70000 },
                new ProductUnit { ProductUnitId = 126, ProductId = 15, UnitName = "Hộp", ConversionRate = 20, Price = 170000, ImportPrice = 135000 }
            );

            // 8. SEED IMPORTS
            modelBuilder.Entity<Import>().HasData(
                new Import { ImportId = 1, ImportCode = "HDN_001", SupplierId = 1, CreatedBy = "Dược sĩ Lê Minh Tâm (Chủ tiệm)", ImportDate = DateTime.Now.AddDays(-30), TotalAmount = 5100000, Status = 1 },
                new Import { ImportId = 2, ImportCode = "HDN_002", SupplierId = 3, CreatedBy = "Dược sĩ Trần Thị Thu", ImportDate = DateTime.Now.AddDays(-15), TotalAmount = 3250000, Status = 1 },
                new Import { ImportId = 3, ImportCode = "HDN_003", SupplierId = 4, CreatedBy = "Dược sĩ Vũ Hoàng Hải", ImportDate = DateTime.Now.AddDays(-5), TotalAmount = 8400000, Status = 1 },
                new Import { ImportId = 4, ImportCode = "HDN_004", SupplierId = 5, CreatedBy = "Dược sĩ Lê Minh Tâm (Chủ tiệm)", ImportDate = DateTime.Now.AddDays(-1), TotalAmount = 2900000, Status = 1 }
            );

            // 9. SEED IMPORT DETAILS
            modelBuilder.Entity<ImportDetail>().HasData(
                new ImportDetail { ImportDetailId = 1, ImportId = 1, ProductId = 1, OriginalQuantity = 2000, CurrentQuantity = 450, ImportPrice = 1500, ExpiryDate = DateTime.Today.AddYears(2), BatchNumber = "LOT-2406-01" },
                new ImportDetail { ImportDetailId = 2, ImportId = 1, ProductId = 4, OriginalQuantity = 200, CurrentQuantity = 15, ImportPrice = 17500, ExpiryDate = DateTime.Today.AddMonths(14), BatchNumber = "LOT-2406-02" },
                new ImportDetail { ImportDetailId = 3, ImportId = 1, ProductId = 8, OriginalQuantity = 1500, CurrentQuantity = 300, ImportPrice = 1000, ExpiryDate = DateTime.Today.AddYears(3), BatchNumber = "LOT-2406-03" },
                new ImportDetail { ImportDetailId = 4, ImportId = 1, ProductId = 14, OriginalQuantity = 50, CurrentQuantity = 8, ImportPrice = 58000, ExpiryDate = DateTime.Today.AddMonths(11), BatchNumber = "LOT-2406-04" },

                new ImportDetail { ImportDetailId = 5, ImportId = 2, ProductId = 11, OriginalQuantity = 500, CurrentQuantity = 220, ImportPrice = 720, ExpiryDate = DateTime.Today.AddMonths(18), BatchNumber = "LOT-2407-01" },
                new ImportDetail { ImportDetailId = 6, ImportId = 2, ProductId = 5, OriginalQuantity = 500, CurrentQuantity = 120, ImportPrice = 3200, ExpiryDate = DateTime.Today.AddDays(20), BatchNumber = "LOT-2407-02" },
                new ImportDetail { ImportDetailId = 7, ImportId = 2, ProductId = 10, OriginalQuantity = 30, CurrentQuantity = 12, ImportPrice = 64000, ExpiryDate = DateTime.Today.AddMonths(8), BatchNumber = "LOT-2407-03" },

                new ImportDetail { ImportDetailId = 8, ImportId = 3, ProductId = 6, OriginalQuantity = 500, CurrentQuantity = 380, ImportPrice = 6800, ExpiryDate = DateTime.Today.AddYears(2), BatchNumber = "LOT-2407-04" },
                new ImportDetail { ImportDetailId = 9, ImportId = 3, ProductId = 7, OriginalQuantity = 300, CurrentQuantity = 260, ImportPrice = 8500, ExpiryDate = DateTime.Today.AddMonths(16), BatchNumber = "LOT-2407-05" },
                new ImportDetail { ImportDetailId = 10, ImportId = 3, ProductId = 12, OriginalQuantity = 40, CurrentQuantity = 35, ImportPrice = 68000, ExpiryDate = DateTime.Today.AddMonths(10), BatchNumber = "LOT-2407-06" },

                new ImportDetail { ImportDetailId = 11, ImportId = 4, ProductId = 2, OriginalQuantity = 150, CurrentQuantity = 150, ImportPrice = 13500, ExpiryDate = DateTime.Today.AddYears(1), BatchNumber = "LOT-2407-07" },
                new ImportDetail { ImportDetailId = 12, ImportId = 4, ProductId = 3, OriginalQuantity = 500, CurrentQuantity = 500, ImportPrice = 3100, ExpiryDate = DateTime.Today.AddYears(2), BatchNumber = "LOT-2407-08" },
                new ImportDetail { ImportDetailId = 13, ImportId = 4, ProductId = 9, OriginalQuantity = 400, CurrentQuantity = 400, ImportPrice = 2000, ExpiryDate = DateTime.Today.AddYears(3), BatchNumber = "LOT-2407-09" },
                new ImportDetail { ImportDetailId = 14, ImportId = 4, ProductId = 13, OriginalQuantity = 10, CurrentQuantity = 10, ImportPrice = 250000, ExpiryDate = DateTime.Today.AddMonths(24), BatchNumber = "LOT-2407-10" },
                new ImportDetail { ImportDetailId = 15, ImportId = 4, ProductId = 15, OriginalQuantity = 25, CurrentQuantity = 25, ImportPrice = 65000, ExpiryDate = DateTime.Today.AddYears(2), BatchNumber = "LOT-2407-11" }
            );

            // 10. SEED PRESCRIPTION FILES 
            modelBuilder.Entity<PrescriptionFile>().HasData(
                new PrescriptionFile { PrescriptionFileId = 1, FileName = "TOA_LOET_DADAY_HUNG.png", FilePath = "toa_daday.png", Note = "Toa thuốc dạ dày - BV Đại học Y Dược", Status = true, UploadDate = DateTime.Now.AddDays(-10) },
                new PrescriptionFile { PrescriptionFileId = 2, FileName = "TOA_VIEMDA_HUNG.png", FilePath = "toa_dalieu.png", Note = "Toa bôi da liễu - Bệnh viện Da Liễu", Status = true, UploadDate = DateTime.Now.AddDays(-10) },
                new PrescriptionFile { PrescriptionFileId = 3, FileName = "TOA_HUYETAP_THAO.png", FilePath = "toa_huyetap.png", Note = "Đơn thuốc huyết áp vô căn mãn tính", Status = true, UploadDate = DateTime.Now.AddDays(-25) },
                new PrescriptionFile { PrescriptionFileId = 4, FileName = "TOA_K_SINH_MINH.png", FilePath = "toa_khangsinh.png", Note = "Toa kháng sinh trị viêm tai giữa", Status = true, UploadDate = DateTime.Now.AddDays(-2) }
            );

            // 11. SEED ORDERS 
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, OrderCode = "HD_001", CustomerId = 1, UserId = 2, PrescriptionFileId = 1, OrderDate = DateTime.Now.AddDays(-10), TotalAmount = 143000, Discount = 0, NetAmount = 143000, Status = true },
                new Order { OrderId = 2, OrderCode = "HD_002", CustomerId = 2, UserId = 2, PrescriptionFileId = 3, OrderDate = DateTime.Now.AddDays(-5), TotalAmount = 414000, Discount = 14000, NetAmount = 400000, Status = false },
                new Order { OrderId = 3, OrderCode = "HD_003", CustomerId = 3, UserId = 3, PrescriptionFileId = 4, OrderDate = DateTime.Now.AddDays(-2), TotalAmount = 250000, Discount = 0, NetAmount = 250000, Status = false },
                new Order { OrderId = 4, OrderCode = "HD_004", CustomerId = null, UserId = 1, PrescriptionFileId = null, OrderDate = DateTime.Now.AddDays(-1), TotalAmount = 222000, Discount = 0, NetAmount = 222000, Status = true },
                new Order { OrderId = 5, OrderCode = "HD_005", CustomerId = 7, UserId = 1, PrescriptionFileId = null, OrderDate = DateTime.Now, TotalAmount = 124000, Discount = 4000, NetAmount = 120000, Status = true }
            );

            // 12. SEED ORDER DETAILS 
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderDetailId = 1, OrderId = 1, ImportDetailId = 2, SoldUnit = "Viên", ConversionRate = 1, Quantity = 2, Price = 24000 },
                new OrderDetail { OrderDetailId = 2, OrderId = 1, ImportDetailId = 10, SoldUnit = "Tuýp", ConversionRate = 1, Quantity = 1, Price = 90000 },
                new OrderDetail { OrderDetailId = 3, OrderId = 1, ImportDetailId = 6, SoldUnit = "Gói", ConversionRate = 1, Quantity = 1, Price = 5000 },

                new OrderDetail { OrderDetailId = 4, OrderId = 2, ImportDetailId = 8, SoldUnit = "Viên", ConversionRate = 1, Quantity = 30, Price = 9200 },
                new OrderDetail { OrderDetailId = 5, OrderId = 2, ImportDetailId = 9, SoldUnit = "Viên", ConversionRate = 1, Quantity = 12, Price = 11500 },

                new OrderDetail { OrderDetailId = 6, OrderId = 3, ImportDetailId = 11, SoldUnit = "Hộp", ConversionRate = 14, Quantity = 1, Price = 160000 },
                new OrderDetail { OrderDetailId = 7, OrderId = 3, ImportDetailId = 1, SoldUnit = "Viên", ConversionRate = 1, Quantity = 36, Price = 2500 },

                new OrderDetail { OrderDetailId = 8, OrderId = 4, ImportDetailId = 7, SoldUnit = "Chai", ConversionRate = 1, Quantity = 1, Price = 82000 },
                new OrderDetail { OrderDetailId = 9, OrderId = 4, ImportDetailId = 4, SoldUnit = "Viên", ConversionRate = 1, Quantity = 1, Price = 78000 },
                new OrderDetail { OrderDetailId = 10, OrderId = 4, ImportDetailId = 15, SoldUnit = "Viên", ConversionRate = 1, Quantity = 1, Price = 62000 },

                new OrderDetail { OrderDetailId = 11, OrderId = 5, ImportDetailId = 13, SoldUnit = "Hộp", ConversionRate = 20, Quantity = 1, Price = 58000 },
                new OrderDetail { OrderDetailId = 12, OrderId = 5, ImportDetailId = 6, SoldUnit = "Gói", ConversionRate = 1, Quantity = 10, Price = 4800 },
                new OrderDetail { OrderDetailId = 13, OrderId = 5, ImportDetailId = 3, SoldUnit = "Vỉ", ConversionRate = 10, Quantity = 1, Price = 18000 }
            );
        }
    }
}