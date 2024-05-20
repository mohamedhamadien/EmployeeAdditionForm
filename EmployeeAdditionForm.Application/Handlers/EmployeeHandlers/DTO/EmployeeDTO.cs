using EmployeeAdditionForm.Domain.Entities;
using EmployeeAdditionForm.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.DTO
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public EmployeeRolesDTO Role { get; set; }
        public Gender Gender { get; set; }
        public bool IsFirsetAppoinment { get; set; }
        public DateTime StartDate { get; set; }
        public string Note { get; set; }
    }

    public class EmployeeRolesDTO
    {
        public string Name { get; set; }
    }
}
