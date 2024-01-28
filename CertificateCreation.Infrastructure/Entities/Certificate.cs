using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateCreation.Infrastructure.Entities
{
    public class Certificate
    {
        public int Id { get; set; }
        public string CertificateName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? Remarks { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
