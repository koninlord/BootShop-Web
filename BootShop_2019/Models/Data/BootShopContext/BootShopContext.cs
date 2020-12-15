using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BootShop_2019.Models.ViewModels;

namespace BootShop_2019.Models.Data.BootShopContext
{
    public partial class BootShopContext : DbContext
    {
        public BootShopContext()
        {
        }

        public BootShopContext(DbContextOptions<BootShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ProductSale> ProductSale { get; set; }
        public virtual DbSet<SalePerson> SalePerson { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ProductCategoryId)
                    .HasName("FK_ProductCategoryProduct");

                entity.HasIndex(e => e.SerialNumber)
                    .HasName("UX_SerialNo")
                    .IsUnique();

                entity.HasIndex(e => e.ShopId)
                    .HasName("FK_ShopProduct");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Price).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductImageId).HasColumnName("ProductImageID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategoryProduct");

                entity.HasOne(d => d.ProductImage)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductImageId)
                    .HasConstraintName("FK_Product_ProductImage");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopProduct");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => e.ProductCategoryId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductCategoryName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasKey(e => e.ProductImageId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.ProductImageId).HasColumnName("ProductImageID");

                entity.Property(e => e.Image).IsRequired();
            });

            modelBuilder.Entity<ProductSale>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ProductId)
                    .HasName("FK_ProductProductSale");

                entity.HasIndex(e => e.SalePersonId)
                    .HasName("FK_SalesPersonProductSale");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateTimeSold)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.SalePersonId).HasColumnName("SalePersonID");

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.ProductSale)
                    .HasForeignKey<ProductSale>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductProductSale");

                entity.HasOne(d => d.SalePerson)
                    .WithMany(p => p.ProductSale)
                    .HasForeignKey(d => d.SalePersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSale_SalePerson");
            });

            modelBuilder.Entity<SalePerson>(entity =>
            {
                entity.HasKey(e => e.SalePersonId)
                    .HasName("PK_SalesPerson")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ShopId)
                    .HasName("FK_ShopSalesPerson");

                entity.Property(e => e.SalePersonId).HasColumnName("SalePersonID");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OtherName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.SalePerson)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShopSalesPerson");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.HasKey(e => e.ShopId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.ShopLocation).HasMaxLength(50);

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }

        public DbSet<BootShop_2019.Models.ViewModels.ProductSaleViewModel> ProductSaleViewModel { get; set; }

        public DbSet<BootShop_2019.Models.ViewModels.ProductViewModel> ProductViewModel { get; set; }
    }
}
