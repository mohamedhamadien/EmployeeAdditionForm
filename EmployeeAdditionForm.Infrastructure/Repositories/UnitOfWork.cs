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

        public UnitOfWork(EmployeeAdditionFormDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private EmployeeRepository _employeeRepository;

       public IEmployeeRepository EmployeeRepository => _employeeRepository ?? new EmployeeRepository(_dbContext);

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
