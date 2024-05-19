using EmployeeAdditionForm.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Infrastructure
{
    public class EmployeeAdditionFormDbContext : DbContext
    {
        public EmployeeAdditionFormDbContext(DbContextOptions<EmployeeAdditionFormDbContext> options)
           : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeRole> Roles { get; set; }
    }
}
