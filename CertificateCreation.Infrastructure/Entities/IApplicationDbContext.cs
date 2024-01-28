using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateCreation.Infrastructure.Entities
{
    public interface IApplicationDbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
