using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StaffContactAPI.Data;

public partial class StaffContactManagementContext : DbContext
{
    public StaffContactManagementContext()
    {
    }

    public StaffContactManagementContext(DbContextOptions<StaffContactManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ContactDetail> ContactDetails { get; set; }

    public virtual DbSet<ContactStaffType> ContactStaffTypes { get; set; }

    public virtual DbSet<ContactStatus> ContactStatuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Staff_Contact_Management;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContactDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ContactDetail");

            entity.Property(e => e.CellPhone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Cell_Phone");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("First_Name");
            entity.Property(e => e.HomePhone)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Home_Phone");
            entity.Property(e => e.IrdNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IRD_Number");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Last_Name");
            entity.Property(e => e.ManagerId).HasDefaultValue(0);
            entity.Property(e => e.MiddleInitial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Middle_Initial");
            entity.Property(e => e.OfficeExtension)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Office_Extension");
            entity.Property(e => e.StaffType).HasColumnName("Staff_Type");
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.StaffTypeNavigation).WithMany(p => p.ContactDetails)
                .HasForeignKey(d => d.StaffType)
                .HasConstraintName("FK_ContactDetails_ContactStaffType");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.ContactDetails)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_ContactDetails_ContactStatus");
        });

        modelBuilder.Entity<ContactStaffType>(entity =>
        {
            entity.ToTable("ContactStaffType");

            entity.Property(e => e.TypeDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Type_Description");
        });

        modelBuilder.Entity<ContactStatus>(entity =>
        {
            entity.ToTable("ContactStatus");

            entity.Property(e => e.StatusDescription)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Status_Description");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
