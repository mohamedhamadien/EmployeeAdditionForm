using EmployeeAdditionForm.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeAdditionFormDbContext _dbContext;

        private EmployeeRepository _employeeRepository;
        private EmployeeRoleRepository _roleRepository;
        public UnitOfWork(EmployeeAdditionFormDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEmployeeRepository Employees => _employeeRepository ?? new EmployeeRepository(_dbContext);

        public IEmployeeRoleRepository Roles => _roleRepository ?? new EmployeeRoleRepository(_dbContext);

        public void Dispose()
        {
           _dbContext.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
           return await _dbContext.SaveChangesAsync();
        }
    }
}
