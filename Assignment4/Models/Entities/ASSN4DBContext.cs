using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Assignment4.Models.Entities;

public partial class ASSN4DBContext : DbContext
{
    public ASSN4DBContext()
    {
    }

    public ASSN4DBContext(DbContextOptions<ASSN4DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Get the directory where the executable is located
            string executableLocation = AppDomain.CurrentDomain.BaseDirectory;
            //Console.WriteLine(executableLocation);

            // Construct the relative path to the database file
            string relativePath = @"..\..\..\ASSN4DB.mdf";

            // Combine the executable location and relative path to get the full path to the database file
            string fullPath = Path.GetFullPath(Path.Combine(executableLocation, relativePath));

            optionsBuilder.UseSqlServer($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath};Integrated Security=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Account__349DA5A627F95F7D");

            entity.ToTable("Account");

            entity.Property(e => e.AccountType).HasMaxLength(100);
            entity.Property(e => e.CurrentBalance).HasDefaultValueSql("((0.000))");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TransactionHistory>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Transact__55433A6B7EE3B2CD");

            entity.ToTable("TransactionHistory");

            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.TransactionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07097F1A41");

            entity.ToTable("User");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Firstname).HasMaxLength(50);
            entity.Property(e => e.Lastname).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
