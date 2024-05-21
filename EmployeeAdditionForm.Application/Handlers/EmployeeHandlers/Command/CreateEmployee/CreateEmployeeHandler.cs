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
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _ctx;

        public CreateEmployeeHandler(IMapper mapper, IUnitOfWork ctx)
        {
            _mapper = mapper;
            _ctx = ctx;
        }
        public async Task<Unit> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var employee = _mapper.Map<Employee>(request);
                _ctx.Employees.AddAsync(employee);
                await _ctx.SaveChangesAsync();
                return Unit.Task.Result;
            }
            catch (Exception ex)
            {

                throw new Exception("Error occurred while creating employee.");
            }
           
        }
    }
}
