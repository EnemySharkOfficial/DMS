using System;
using System.Collections.Generic;
using DBMS_API.Domain.Models.ServiceDepartment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBMS_API.DataAccess
{
    public partial class ServiceDepartmentContext : DbContext
    {
        public ServiceDepartmentContext()
        {
        }

        public ServiceDepartmentContext(DbContextOptions<ServiceDepartmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ServiceCar> ServiceCar { get; set; } = null!;
        public virtual DbSet<ServiceClient> ServiceClient { get; set; } = null!;
        public virtual DbSet<CurrentService> CurrentServices { get; set; } = null!;
        public virtual DbSet<CurrentServiceMaster> CurrentServiseMasters { get; set; } = null!;
        public virtual DbSet<ServiceManager> ServiceManager { get; set; } = null!;
        public virtual DbSet<Master> Masters { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;


      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ANDRYLAPTOP;Database=db_user_new_v4;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
         

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceCar>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CAR");

                entity.ToTable("car");

                entity.Property(e => e.Id).HasColumnName("id_car");

                entity.Property(e => e.Brand)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("brand");

                entity.Property(e => e.Characteristics)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("characteristics");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Equipment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("equipment");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdMaster).HasColumnName("id_master");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.Model)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Year)
                    .HasColumnType("date")
                    .HasColumnName("year");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("car_fk0");

                entity.HasOne(d => d.IdMasterNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.IdMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("car_fk1");
            });

            modelBuilder.Entity<ServiceClient>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CLIENT");

                entity.ToTable("ServiceClient");

                entity.Property(e => e.Id).HasColumnName("id_client");

                entity.Property(e => e.Fio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FIO");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.PassportData)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("passport_data");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Phone_number");
            });

            modelBuilder.Entity<CurrentService>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CURRENT_SERVICE");

                entity.ToTable("current_service");

                entity.Property(e => e.Id).HasColumnName("id_current_service");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IdCar).HasColumnName("id_car");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.WayOfImplementation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("way_of_implementation");

                entity.HasOne(d => d.IdCarNavigation)
                    .WithMany(p => p.CurrentServices)
                    .HasForeignKey(d => d.IdCar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("current_service_fk1");

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.CurrentServices)
                    .HasForeignKey(d => d.IdService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("current_service_fk0");
            });

            modelBuilder.Entity<CurrentServiceMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("current_servise_master");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IdCurrentServise).HasColumnName("id_current_servise");

                entity.Property(e => e.IdMaster).HasColumnName("id_master");

                entity.HasOne(d => d.IdCurrentServiseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCurrentServise)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("current_servise_master_fk0");

                entity.HasOne(d => d.IdMasterNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMaster)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("current_servise_master_fk1");
            });

            modelBuilder.Entity<ServiceManager>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_MANAGER");

                entity.ToTable("ServiceManager");

                entity.Property(e => e.Id).HasColumnName("id_manager");

                entity.Property(e => e.Fio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FIO");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.PassportData)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("passport_data");
            });

            modelBuilder.Entity<Master>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_MASTER");

                entity.ToTable("master");

                entity.Property(e => e.Id).HasColumnName("id_master");

                entity.Property(e => e.Fio)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FIO");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.PassportData)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("passport_data");

                entity.Property(e => e.Post)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("post");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.Masters)
                    .HasForeignKey(d => d.IdManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("master_fk0");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_SERVICE");

                entity.ToTable("service");

                entity.Property(e => e.Id).HasColumnName("id_service");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Prise).HasColumnName("prise");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("service_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        
    }

}
