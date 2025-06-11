using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Models;

public partial class NewThingDbContext : DbContext
{
    public NewThingDbContext()
    {
    }

    public NewThingDbContext(DbContextOptions<NewThingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Child> Children { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Healthcheck> Healthchecks { get; set; }

    public virtual DbSet<Salary> Salaries { get; set; }

    public virtual DbSet<Sickleave> Sickleaves { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SHITBOXLITE;Database=NewThing;Trusted_Connection=true;MultipleActiveResultSets=true; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("PK__address__C135F5E9C718C52F");

            entity.ToTable("address");

            entity.Property(e => e.Employeeid)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("employeeid");
            entity.Property(e => e.Administrativedivision)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("administrativedivision");
            entity.Property(e => e.Buildingapartment).HasColumnName("buildingapartment");
            entity.Property(e => e.Buildingnumber).HasColumnName("buildingnumber");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Postalcode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("postalcode");
            entity.Property(e => e.Squaremeters).HasColumnName("squaremeters");
            entity.Property(e => e.Streetname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("streetname");
            entity.Property(e => e.Townname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("townname");

            entity.HasOne(d => d.Employee).WithOne(p => p.Address)
                .HasForeignKey<Address>(d => d.Employeeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__address__employe__44FF419A");
        });

        modelBuilder.Entity<Child>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__child__3213E83FEC79D1B3");

            entity.ToTable("child");

            entity.Property(e => e.Id)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("employeeid");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastname");

            entity.HasOne(d => d.Employee).WithMany(p => p.Children)
                .HasForeignKey(d => d.Employeeid)
                .HasConstraintName("FK__child__employeei__398D8EEE");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3213E83FBCFEAA7C");

            entity.ToTable("employee");

            entity.Property(e => e.Id)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Addresscode).HasColumnName("addresscode");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Jobhistoryid)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("jobhistoryid");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Positioncode).HasColumnName("positioncode");
        });

        modelBuilder.Entity<Healthcheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__healthch__3213E83FCE2BF2E5");

            entity.ToTable("healthcheck");

            entity.Property(e => e.Id)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Employeeid)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("employeeid");
            entity.Property(e => e.Ishealthy).HasColumnName("ishealthy");
            entity.Property(e => e.Lastcheckdate).HasColumnName("lastcheckdate");

            entity.HasOne(d => d.Employee).WithMany(p => p.Healthchecks)
                .HasForeignKey(d => d.Employeeid)
                .HasConstraintName("FK__healthche__emplo__3C69FB99");
        });

        modelBuilder.Entity<Salary>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("PK__salary__C135F5E9A83BAFA4");

            entity.ToTable("salary");

            entity.Property(e => e.Employeeid)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("employeeid");
            entity.Property(e => e.Bonus)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("bonus");
            entity.Property(e => e.Salaryamount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("salaryamount");
            entity.Property(e => e.Startdate).HasColumnName("startdate");

            entity.HasOne(d => d.Employee).WithOne(p => p.Salary)
                .HasForeignKey<Salary>(d => d.Employeeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__salary__employee__3F466844");
        });

        modelBuilder.Entity<Sickleave>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("PK__sickleav__C135F5E952FEDE49");

            entity.ToTable("sickleave");

            entity.Property(e => e.Employeeid)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("employeeid");
            entity.Property(e => e.Enddate).HasColumnName("enddate");
            entity.Property(e => e.Startdate).HasColumnName("startdate");
            entity.Property(e => e.Wasonleave).HasColumnName("wasonleave");

            entity.HasOne(d => d.Employee).WithOne(p => p.Sickleave)
                .HasForeignKey<Sickleave>(d => d.Employeeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__sickleave__emplo__4222D4EF");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
