using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.DTO;
using EmployeeAdditionForm.Application.Handlers.EmployeeRolesHandlers.DTO;
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
    public class CreateEmployeeRoleCommad : IRequest<EmployeeRoleDTO>
    {
        public string Name { get; set; }
    }
}
