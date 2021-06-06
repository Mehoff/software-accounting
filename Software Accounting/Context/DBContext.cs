using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Software_Accounting.Models;

#nullable disable

namespace Software_Accounting.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<ProgressStatus> ProgressStatuses { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Server=USER-PC\SQLEXPRESS;Database=SoftwareAccounting;Trusted_Connection=True;");

                //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SoftwareAccounting;Trusted_Connection=True;");

                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(35);

                entity.Property(e => e.Fullname).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.PositionFk).HasColumnName("PositionFK");

                entity.Property(e => e.UserTypeFk).HasColumnName("UserTypeFK");

                entity.HasOne(d => d.PositionFkNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PositionFk)
                    .HasConstraintName("FK__Employees__UserT__286302EC");

                entity.HasOne(d => d.UserTypeFkNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.UserTypeFk)
                    .HasConstraintName("FK__Employees__UserT__29572725");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(40);
            });

            modelBuilder.Entity<ProgressStatus>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Software>(entity =>
            {
                entity.ToTable("Software");

                entity.Property(e => e.AuthorFk).HasColumnName("AuthorFK");

                entity.Property(e => e.BeginDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ProgressStatusFk).HasColumnName("ProgressStatusFK");

                entity.Property(e => e.ProjectFk).HasColumnName("ProjectFK");

                entity.Property(e => e.SourceUrl)
                    .HasMaxLength(1)
                    .HasColumnName("SourceURL");

                entity.HasOne(d => d.AuthorFkNavigation)
                    .WithMany(p => p.Softwares)
                    .HasForeignKey(d => d.AuthorFk)
                    .HasConstraintName("FK__Software__Author__300424B4");

                entity.HasOne(d => d.ProgressStatusFkNavigation)
                    .WithMany(p => p.Softwares)
                    .HasForeignKey(d => d.ProgressStatusFk)
                    .HasConstraintName("FK__Software__Progre__31EC6D26");

                entity.HasOne(d => d.ProjectFkNavigation)
                    .WithMany(p => p.Softwares)
                    .HasForeignKey(d => d.ProjectFk)
                    .HasConstraintName("FK__Software__Projec__30F848ED");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
