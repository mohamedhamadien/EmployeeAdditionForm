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

        public async Task<List<EmployeeRole>> GetAllAsync()
        {
            return await _dbContext.Roles.ToListAsync();
        }

        public bool IsExisted(Guid id)
        {
         return  _dbContext.Roles.Any(r => r.Id == id);
        }
    }
}
