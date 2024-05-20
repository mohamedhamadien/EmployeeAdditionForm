using AutoMapper;
using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.DTO;
using EmployeeAdditionForm.Application.Handlers.EmployeeRolesHandlers.DTO;
using EmployeeAdditionForm.Domain.Entities;
using EmployeeAdditionForm.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Command.CreateEmployee
{
    public class CreateEmployeeRoleHandler : IRequestHandler<CreateEmployeeRoleCommad, EmployeeRoleDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _ctx;

        public CreateEmployeeRoleHandler(IMapper mapper, IUnitOfWork ctx)
        {
            _mapper = mapper;
            _ctx = ctx;
        }
        public async Task<EmployeeRoleDTO> Handle(CreateEmployeeRoleCommad request, CancellationToken cancellationToken)
        {
           var employee =  _mapper.Map<EmployeeRole>(request);
            _ctx.Roles.AddAsync(employee);
           await _ctx.SaveChangesAsync();
            return _mapper.Map(employee,new EmployeeRoleDTO());
        }
    }
}
