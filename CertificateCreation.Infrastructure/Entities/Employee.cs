using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateCreation.Infrastructure.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public  string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTimeOffset DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string Address { get; set; } = string.Empty;
        public DateTimeOffset JoiningDate { get; set; }
        public Department? Department { get; set; }
        public Designation? Designation { get; set; }

        public List<Certificate>? Certificates { get;}
    }
}
