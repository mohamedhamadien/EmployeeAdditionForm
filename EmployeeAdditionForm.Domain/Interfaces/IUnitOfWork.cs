using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable 
    {
        IEmployeeRepository Employees { get; }
        IEmployeeRoleRepository Roles { get; }
        Task<int> SaveChangesAsync();

    }
}
