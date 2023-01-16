using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DotNetSale.Backend.Data.Data;

public partial class PuntoventaContext : DbContext
{
    public PuntoventaContext()
    {
    }

    public PuntoventaContext(DbContextOptions<PuntoventaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EksUser> EksUsers { get; set; }

    public virtual DbSet<Entry> Entries { get; set; }

    public virtual DbSet<EntryDetail> EntryDetails { get; set; }

    public virtual DbSet<Loss> Losses { get; set; }

    public virtual DbSet<LossDetail> LossDetails { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Operation> Operations { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<RolOperation> RolOperations { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SaleDetail> SaleDetails { get; set; }

    public virtual DbSet<StatusProduct> StatusProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=vicentc0de.com;database=puntoventa;uid=puntoventa;pwd=PuntoD3V3nta25;sslmode=none", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.3.37-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<EksUser>(entity =>
        {
            entity.HasKey(e => e.IdEksUser).HasName("PRIMARY");

            entity.ToTable("EksUser");

            entity.HasIndex(e => e.IdRol, "IdRol");

            entity.Property(e => e.IdEksUser).HasColumnType("int(11)");
            entity.Property(e => e.DateEksUser).HasColumnType("datetime");
            entity.Property(e => e.EmailEksUser).HasMaxLength(50);
            entity.Property(e => e.IdRol).HasColumnType("int(11)");
            entity.Property(e => e.NameEksUser).HasMaxLength(50);
            entity.Property(e => e.PasswordEksUser).HasMaxLength(256);

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.EksUsers)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("EksUser_ibfk_1");
        });

        modelBuilder.Entity<Entry>(entity =>
        {
            entity.HasKey(e => e.IdIn).HasName("PRIMARY");

            entity.ToTable("Entry");

            entity.HasIndex(e => e.IdStatus, "IdStatus");

            entity.Property(e => e.IdIn).HasColumnType("bigint(20)");
            entity.Property(e => e.DateIn).HasColumnType("datetime");
            entity.Property(e => e.IdStatus).HasColumnType("int(11)");
            entity.Property(e => e.TotalIn).HasPrecision(10, 2);

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Entries)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("Entry_ibfk_1");
        });

        modelBuilder.Entity<EntryDetail>(entity =>
        {
            entity.HasKey(e => e.IdEd).HasName("PRIMARY");

            entity.HasIndex(e => e.IdIn, "IdIn");

            entity.HasIndex(e => e.IdProduct, "IdProduct");

            entity.Property(e => e.IdEd)
                .HasColumnType("bigint(20)")
                .HasColumnName("IdED");
            entity.Property(e => e.IdIn).HasColumnType("bigint(20)");
            entity.Property(e => e.IdProduct).HasColumnType("bigint(20)");
            entity.Property(e => e.QuantityEd)
                .HasColumnType("int(11)")
                .HasColumnName("QuantityED");
            entity.Property(e => e.UnitCostEd)
                .HasPrecision(10, 2)
                .HasColumnName("UnitCostED");

            entity.HasOne(d => d.IdInNavigation).WithMany(p => p.EntryDetails)
                .HasForeignKey(d => d.IdIn)
                .HasConstraintName("EntryDetails_ibfk_1");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.EntryDetails)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("EntryDetails_ibfk_2");
        });

        modelBuilder.Entity<Loss>(entity =>
        {
            entity.HasKey(e => e.IdLoss).HasName("PRIMARY");

            entity.ToTable("Loss");

            entity.HasIndex(e => e.IdStatus, "IdStatus");

            entity.Property(e => e.IdLoss).HasColumnType("bigint(20)");
            entity.Property(e => e.DateLoss).HasColumnType("datetime");
            entity.Property(e => e.IdStatus).HasColumnType("int(11)");
            entity.Property(e => e.TotalLoss).HasPrecision(10, 2);

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Losses)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Loss_ibfk_1");
        });

        modelBuilder.Entity<LossDetail>(entity =>
        {
            entity.HasKey(e => e.IdLd).HasName("PRIMARY");

            entity.ToTable("LossDetail");

            entity.HasIndex(e => e.IdLoss, "IdLoss");

            entity.HasIndex(e => e.IdProduct, "IdProduct");

            entity.Property(e => e.IdLd)
                .HasColumnType("bigint(20)")
                .HasColumnName("IdLD");
            entity.Property(e => e.IdLoss).HasColumnType("bigint(20)");
            entity.Property(e => e.IdProduct).HasColumnType("bigint(20)");
            entity.Property(e => e.QuantityLd)
                .HasColumnType("int(11)")
                .HasColumnName("QuantityLD");
            entity.Property(e => e.UnitCostLd)
                .HasPrecision(10, 2)
                .HasColumnName("UnitCostLD");

            entity.HasOne(d => d.IdLossNavigation).WithMany(p => p.LossDetails)
                .HasForeignKey(d => d.IdLoss)
                .HasConstraintName("LossDetail_ibfk_1");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.LossDetails)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("LossDetail_ibfk_2");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.IdModule).HasName("PRIMARY");

            entity.ToTable("Module");

            entity.Property(e => e.IdModule).HasColumnType("int(11)");
            entity.Property(e => e.NameModule).HasMaxLength(50);
        });

        modelBuilder.Entity<Operation>(entity =>
        {
            entity.HasKey(e => e.IdOperation).HasName("PRIMARY");

            entity.ToTable("Operation");

            entity.HasIndex(e => e.IdModule, "IdModule");

            entity.Property(e => e.IdOperation).HasColumnType("int(11)");
            entity.Property(e => e.IdModule).HasColumnType("int(11)");
            entity.Property(e => e.NameOperation).HasMaxLength(50);

            entity.HasOne(d => d.IdModuleNavigation).WithMany(p => p.Operations)
                .HasForeignKey(d => d.IdModule)
                .HasConstraintName("Operation_ibfk_1");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("PRIMARY");

            entity.ToTable("Product");

            entity.Property(e => e.IdProduct).HasColumnType("bigint(20)");
            entity.Property(e => e.CodeProduct).HasMaxLength(50);
            entity.Property(e => e.CostProduct).HasPrecision(10, 2);
            entity.Property(e => e.DateProduct).HasColumnType("datetime");
            entity.Property(e => e.ExistenceProduct).HasColumnType("bigint(20)");
            entity.Property(e => e.NameProduct).HasMaxLength(50);
            entity.Property(e => e.PriceProduct).HasPrecision(10, 2);
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PRIMARY");

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol).HasColumnType("int(11)");
            entity.Property(e => e.NameRol).HasMaxLength(50);
        });

        modelBuilder.Entity<RolOperation>(entity =>
        {
            entity.HasKey(e => e.IdRo).HasName("PRIMARY");

            entity.ToTable("RolOperation");

            entity.HasIndex(e => e.IdOperation, "IdOperation");

            entity.HasIndex(e => e.IdRol, "IdRol");

            entity.Property(e => e.IdRo)
                .HasColumnType("int(11)")
                .HasColumnName("IdRO");
            entity.Property(e => e.IdOperation).HasColumnType("int(11)");
            entity.Property(e => e.IdRol).HasColumnType("int(11)");

            entity.HasOne(d => d.IdOperationNavigation).WithMany(p => p.RolOperations)
                .HasForeignKey(d => d.IdOperation)
                .HasConstraintName("RolOperation_ibfk_2");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolOperations)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("RolOperation_ibfk_1");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.IdSale).HasName("PRIMARY");

            entity.ToTable("Sale");

            entity.HasIndex(e => e.IdStatus, "IdStatus");

            entity.Property(e => e.IdSale).HasColumnType("bigint(20)");
            entity.Property(e => e.DateSale).HasColumnType("datetime");
            entity.Property(e => e.IdStatus).HasColumnType("int(11)");
            entity.Property(e => e.TotalSale).HasPrecision(10, 2);

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("Sale_ibfk_1");
        });

        modelBuilder.Entity<SaleDetail>(entity =>
        {
            entity.HasKey(e => e.IdSd).HasName("PRIMARY");

            entity.HasIndex(e => e.IdProduct, "IdProduct");

            entity.HasIndex(e => e.IdSale, "IdSale");

            entity.Property(e => e.IdSd)
                .HasColumnType("bigint(20)")
                .HasColumnName("IdSD");
            entity.Property(e => e.IdProduct).HasColumnType("bigint(20)");
            entity.Property(e => e.IdSale).HasColumnType("bigint(20)");
            entity.Property(e => e.QuantitySd)
                .HasColumnType("int(11)")
                .HasColumnName("QuantitySD");
            entity.Property(e => e.UnitCostSd)
                .HasPrecision(10, 2)
                .HasColumnName("UnitCostSD");
            entity.Property(e => e.UnitePriceSd)
                .HasPrecision(10, 2)
                .HasColumnName("UnitePriceSD");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.SaleDetails)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("SaleDetails_ibfk_1");

            entity.HasOne(d => d.IdSaleNavigation).WithMany(p => p.SaleDetails)
                .HasForeignKey(d => d.IdSale)
                .HasConstraintName("SaleDetails_ibfk_2");
        });

        modelBuilder.Entity<StatusProduct>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PRIMARY");

            entity.Property(e => e.IdStatus).HasColumnType("int(11)");
            entity.Property(e => e.NameStatus).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
