using EmployeeAdditionForm.Domain.Comman;
using EmployeeAdditionForm.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Domain.Entities
{
    public class Employee :BaseEntity
    {
        public string Name { get; set; }
        public EmployeeRole Role { get; set; }
        public Gender Gender { get; set; }
        public bool IsFirsetAppoinment { get; set; }
        public DateTime StartDate { get; set; }
        public string Note { get; set; }
    }
}
