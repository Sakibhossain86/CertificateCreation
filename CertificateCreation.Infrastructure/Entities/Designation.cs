﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateCreation.Infrastructure.Entities
{
    public class Designation
    {
        public int Id { get; set; }
        public string DesignationName { get; set; } = string.Empty;
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
