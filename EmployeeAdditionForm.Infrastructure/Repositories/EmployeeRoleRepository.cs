using EmployeeAdditionForm.Domain.Entities;
using EmployeeAdditionForm.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Infrastructure.Repositories
{
    public class EmployeeRoleRepository : IEmployeeRoleRepository
    {
        private readonly EmployeeAdditionFormDbContext _dbContext;

        public EmployeeRoleRepository(EmployeeAdditionFormDbContext ctx)
        {
            _dbContext = ctx;
        }

        public async Task<EmployeeRole> AddAsync(EmployeeRole role)
        {
            await _dbContext.Roles.AddAsync(role);

            return role;
        }
    }
}
