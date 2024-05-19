using AutoMapper;
using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.DTO;
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
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommad, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _ctx;

        public CreateEmployeeHandler(IMapper mapper, IUnitOfWork ctx)
        {
            _mapper = mapper;
            _ctx = ctx;
        }
        public Task<Unit> Handle(CreateEmployeeCommad request, CancellationToken cancellationToken)
        {
           var employee =  _mapper.Map<Employee>(request);
            _ctx.Employees.AddAsync(employee);
            return Unit.Task;
        }
    }
}
