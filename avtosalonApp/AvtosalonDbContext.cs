using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace avtosalonApp;

public partial class AvtosalonDbContext : DbContext
{
    public AvtosalonDbContext()
    {
    }

    public AvtosalonDbContext(DbContextOptions<AvtosalonDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Deal> Deals { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=nikolaidddd;Database=avtosalon_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK__Car__68A0342EF3F1B19B");

            entity.ToTable("Car");

            entity.Property(e => e.CarBrand)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CarModel)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Color)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.VinNumber)
                .HasMaxLength(18)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.LoginClient).HasName("PK__Client__131A0F6E4E03F800");

            entity.ToTable("Client");

            entity.Property(e => e.LoginClient)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ClientCity)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClientPhoneNumber)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.ClientResidentialAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClientsFullName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PasswordClient)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Deal>(entity =>
        {
            entity.HasKey(e => e.DealId).HasName("PK__Deal__E5B28166DB596D12");

            entity.ToTable("Deal");

            entity.Property(e => e.DealidCar).HasColumnName("DeaIIdCar");
            entity.Property(e => e.LoginClient)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LoginEmpl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.DealidCarNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.DealidCar)
                .HasConstraintName("FK__Deal__DeaIIdCar__412EB0B6");

            entity.HasOne(d => d.LoginClientNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.LoginClient)
                .HasConstraintName("FK__Deal__LoginClien__4316F928");

            entity.HasOne(d => d.LoginEmplNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.LoginEmpl)
                .HasConstraintName("FK__Deal__LoginEmpl__4222D4EF");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.LoginEmpl).HasName("PK__Employee__4DFAC6F2E28EBDA1");

            entity.ToTable("Employee");

            entity.Property(e => e.LoginEmpl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmplFullName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmplPhoneNumber)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.EmplResidentialAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PasswordEmpl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
