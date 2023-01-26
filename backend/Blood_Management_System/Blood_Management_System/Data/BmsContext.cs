using System;
using System.Collections.Generic;
using Blood_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Blood_Management_System.Data;

public partial class BmsContext : DbContext
{
    public BmsContext()
    {
    }

    public BmsContext(DbContextOptions<BmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BloodRequest> BloodRequests { get; set; }

    public virtual DbSet<Donor> Donors { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BloodRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BloodReq__3214EC07AD11FD9B");

            entity.ToTable("BloodRequest");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AttendantName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AttendantPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Case)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DonorContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DonorName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HospitalName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PickAndDrop)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequestorName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequestorPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequestorRollNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequiredBloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TimeAndDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Donor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Donor__3214EC074E2B53BF");

            entity.ToTable("Donor");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BloodGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastDonationDate).HasColumnType("date");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermanentAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RollNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TemporaryAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Member__3214EC0755BBA30D");

            entity.ToTable("Member");

            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ListGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RollNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
