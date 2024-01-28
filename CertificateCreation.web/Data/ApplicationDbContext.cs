using CertificateCreation.Infrastructure.Entities;
using CertificateCreation.web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CertificateCreation.web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //One to One Employee to Department
            modelBuilder.Entity<Employee>()
            .HasOne<Department>(e => e.Department)
            .WithOne(d => d.Employee)
            .HasForeignKey<Department>(d => d.EmployeeId);

            //One to One Employee to Department
            modelBuilder.Entity<Employee>()
            .HasOne<Designation>(e => e.Designation)
            .WithOne(d => d.Employee)
            .HasForeignKey<Designation>(d => d.EmployeeId);

            modelBuilder.Entity<Certificate>()
            .HasOne<Employee>(c => c.Employee)
            .WithMany(e => e.Certificates)
            .HasForeignKey(c => c.EmployeeId);


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}
