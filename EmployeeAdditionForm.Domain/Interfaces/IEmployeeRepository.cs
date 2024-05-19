using EmployeeAdditionForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddAsync(Employee employee);
    }
}
