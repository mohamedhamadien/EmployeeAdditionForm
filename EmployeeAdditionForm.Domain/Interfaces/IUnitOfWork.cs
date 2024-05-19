using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable 
    {
        IEmployeeRepository EmployeeRepository { get; }
        IEmployeeRoleRepository EmployeeRoleRepository { get; }
        Task<int> SaveChangesAsync();

    }
}
