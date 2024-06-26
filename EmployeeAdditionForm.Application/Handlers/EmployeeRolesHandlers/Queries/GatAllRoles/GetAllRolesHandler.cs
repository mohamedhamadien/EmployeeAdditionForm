﻿using AutoMapper;
using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.DTO;
using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Queries.GetAllEmployees;
using EmployeeAdditionForm.Application.Handlers.EmployeeRolesHandlers.DTO;
using EmployeeAdditionForm.Domain.Entities;
using EmployeeAdditionForm.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeRolesHandlers.Queries.GatAllRoles
{
    public class GetAllRolesHandler : IRequestHandler<GetAllRolesQuery, ICollection<EmployeeRoleDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _ctx;

        public GetAllRolesHandler(IMapper mapper, IUnitOfWork ctx)
        {
            _mapper = mapper;
            _ctx = ctx;
        }

        public async Task<ICollection<EmployeeRoleDTO>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {     
            try
            {
                var allRoles = await _ctx.Roles.GetAllAsync();
                var Data = _mapper.Map<List<EmployeeRoleDTO>>(allRoles);
                return Data;
            }
            catch (Exception ex)
            {

                throw new Exception("Error occurred while retrieve roles.");
            }

        }
    }
}
