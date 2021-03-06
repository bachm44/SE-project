﻿using Microsoft.EntityFrameworkCore;
using se_project.Models;

#nullable disable

namespace se_project
{
    public partial class CompanyDBEntities : DbContext
    {
        public CompanyDBEntities(DbContextOptions<CompanyDBEntities> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");
            OnModelCreatingPartial(modelBuilder);
            //client-visit
            modelBuilder.Entity<Visit>()
                .HasOne(p => p.CarOwner)
                .WithMany(b => b.UserVisits)
                .HasForeignKey(p => p.CarOwnerUsername);
            //employee-visit
            modelBuilder.Entity<EmployeeVisit>().HasKey(e => new { e.Username, e.VisitId });
            //insurance
            modelBuilder.Entity<Insurance>()
                .HasOne(i => i.Car)
                .WithMany(c => c.Insurances)
                .HasForeignKey(c => c.LicensePlate);
            modelBuilder.Entity<Insurance>()
                .HasKey(i => new { i.LicensePlate, i.Type });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<User> Users { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<DiagnosticProfile> DiagnosticProfiles { get; set; }
        public DbSet<EmployeeVisit> EmployeesVisits { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
    }
}
