using EmployeeAdditionForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Domain.Interfaces
{
    public interface IEmployeeRoleRepository
    {
        Task<EmployeeRole> AddAsync(EmployeeRole employee);
        Task<List<EmployeeRole>> GetAllAsync();
        bool IsExisted(Guid id);

    }
}
