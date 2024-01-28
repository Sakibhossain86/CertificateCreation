using CertificateCreation.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateCreation.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public Task<int> Add(Department entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Department> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Department>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
