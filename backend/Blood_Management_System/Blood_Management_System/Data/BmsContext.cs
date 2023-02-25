using System;
using System.Collections.Generic;
using Blood_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Blood_Management_System.Data
{
    public class BmsContext : DbContext
    {
        public BmsContext()
        {
        }

        public BmsContext(DbContextOptions<BmsContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BMS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlServer("Server=bmsdb;Database=BMS;User Id=SA;password=yourStrong(!)Password;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True");

        public DbSet<BloodRequest> BloodRequests { get; set; }

        public DbSet<Donor> Donors { get; set; }

        public DbSet<Member> Members { get; set; }

        //public int UserId { get; set; }

        //public override int SaveChanges()
        //{
        //    var addedEntries = ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToList();
        //    var updatedEntries = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToList();
        //    var deletedEntries = ChangeTracker.Entries().Where(e => e.State == EntityState.Deleted).ToList();

        //    foreach (var entity in addedEntries)
        //    {
        //        var data = entity.Entity;
        //        var temp = (IAudit)data;
        //        temp.UserAdd = UserId;
        //        temp.isActive = true;
        //        temp.CreatedDate = DateTime.Now;
        //        temp.ModifiedDate = DateTime.Now;

        //    }

        //    foreach (var entity in updatedEntries)
        //    {
        //        var temp = (IAudit)entity.Entity;
        //        temp.UserMod = UserId;
        //        temp.ModifiedDate = DateTime.Now;
        //    }

        //    foreach (var entity in deletedEntries)
        //    {
        //        try
        //        {
        //            var temp = (IAudit)entity.Entity;
        //            temp.isActive = false;
        //            temp.UserDel = UserId;
        //            entity.State = EntityState.Modified;
        //        }
        //        catch
        //        {
        //            continue;
        //        }

        //    }
        //    ChangeTracker.DetectChanges();
        //    return base.SaveChanges();
        //}
    }
}
