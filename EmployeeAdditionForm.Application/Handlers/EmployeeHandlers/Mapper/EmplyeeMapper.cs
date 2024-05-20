using AutoMapper;
using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Command.CreateEmployee;
using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.DTO;
using EmployeeAdditionForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Mapper
{
    public class EmplyeeMapper : Profile
    {
        public EmplyeeMapper()
        {
            CreateMap<CreateEmployeeCommand, Employee>();
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<EmployeeRole, EmployeeRolesDTO>();
        }
    }
}
