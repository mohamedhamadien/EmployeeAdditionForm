using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.DTO;
using EmployeeAdditionForm.Application.Handlers.EmployeeRolesHandlers.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeRolesHandlers.Queries.GatAllRoles
{
    public class GetAllRolesQuery : IRequest<ICollection<EmployeeRoleDTO>>
    {
    }
}
