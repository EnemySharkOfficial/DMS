using System;
using System.Collections.Generic;
using DBMS_API.Domain.Models.MarketingDepartment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBMS_API.DataAccess
{
    public partial class MarketingDepartmentContext : DbContext
    {
        public MarketingDepartmentContext()
        {
        }

        public MarketingDepartmentContext(DbContextOptions<MarketingDepartmentContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<CarClass> Carsclasses { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Contract> Contracts { get; set; } = null!;
        public virtual DbSet<Manager> Managers { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductsToSold> ProductsTosolds { get; set; } = null!;
        public virtual DbSet<Soldproduct> Soldproducts { get; set; } = null!;
        
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("cars");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Additional).HasColumnName("additional");

                entity.Property(e => e.Booking).HasColumnName("booking");

                entity.Property(e => e.Equipment).HasColumnName("equipment");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Placement).HasColumnName("placement");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Releasedate).HasColumnName("releasedate");

                entity.Property(e => e.Specialoffer).HasColumnName("specialoffer");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("fk_manager");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fk_parent");
            });

            modelBuilder.Entity<CarClass>(entity =>
            {
                entity.ToTable("carsclass");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand).HasColumnName("brand");

                entity.Property(e => e.Characteristics).HasColumnName("characteristics");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Model).HasColumnName("model");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Fio).HasColumnName("fio");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.Passportdata).HasColumnName("passportdata");

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.Requisites).HasColumnName("requisites");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("fk_manager");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("contracts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Clientrequisites).HasColumnName("clientrequisites");

                entity.Property(e => e.Companyinformation).HasColumnName("companyinformation");

                entity.Property(e => e.Companyrequisites).HasColumnName("companyrequisites");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("managers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Fio).HasColumnName("fio");

                entity.Property(e => e.Passportdata).HasColumnName("passportdata");

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.Post).HasColumnName("post");

                entity.Property(e => e.Requisites).HasColumnName("requisites");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<ProductsToSold>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("ProductsToSold_pkey");

                entity.ToTable("productsTosold");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.NumberOfProducts).HasColumnName("numberOfProducts");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ProductsTosolds)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductsTosolds)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product");
            });

            modelBuilder.Entity<Soldproduct>(entity =>
            {
                entity.ToTable("soldproducts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Soldproducts)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("fk_manager");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Soldproducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("fk_product");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        */
    }
}
