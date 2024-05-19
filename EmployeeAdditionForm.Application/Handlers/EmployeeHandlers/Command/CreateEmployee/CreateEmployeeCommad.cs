using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.DTO;
using EmployeeAdditionForm.Domain.Entities;
using EmployeeAdditionForm.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Command.CreateEmployee
{
    public class CreateEmployeeCommad : IRequest<Unit>
    {
        public string Name { get; set; }
        public Guid RoleId { get; set; }
        public int Gender { get; set; }
        public bool IsFirsetAppoinment { get; set; }
        public DateTime StartDate { get; set; }
        public string Note { get; set; }
    }
}
