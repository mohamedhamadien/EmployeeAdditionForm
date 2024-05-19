using EmployeeAdditionForm.Domain.Entities;
using EmployeeAdditionForm.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeAdditionFormDbContext _dbContext;

        public EmployeeRepository(EmployeeAdditionFormDbContext ctx)
        {
            _dbContext = ctx;
        }

        public async Task<Employee> AddAsync(Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee);
        
            return employee;
        }

        public async Task<IReadOnlyList<Employee>> GetAllAsync()
        {
           return await _dbContext.Employees.Include(x => x.Role).ToListAsync();
        }
    }
}
