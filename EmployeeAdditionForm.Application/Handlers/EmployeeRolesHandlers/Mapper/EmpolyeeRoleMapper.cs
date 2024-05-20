using AutoMapper;
using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Command.CreateEmployee;
using EmployeeAdditionForm.Application.Handlers.EmployeeRolesHandlers.DTO;
using EmployeeAdditionForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeRolesHandlers.Mapper
{
    public class EmpolyeeRoleMapper : Profile
    {
        public EmpolyeeRoleMapper()
        {
            CreateMap<CreateEmployeeRoleCommad, EmployeeRole>();
            CreateMap<EmployeeRole, EmployeeRoleDTO>()
                .ForMember(des => des.Id , src => src.MapFrom(s => s.Id))
                .ForMember(des => des.Name , src => src.MapFrom(s => s.Name));
            
        }

    }
}
