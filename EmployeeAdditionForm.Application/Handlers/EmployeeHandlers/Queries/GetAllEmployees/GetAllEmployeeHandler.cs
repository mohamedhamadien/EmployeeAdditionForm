using AutoMapper;
using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.DTO;
using EmployeeAdditionForm.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Queries.GetAllEmployees
{
    public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, IReadOnlyList<EmployeeDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _ctx;

        public GetAllEmployeeHandler(IMapper mapper, IUnitOfWork ctx)
        {
            _mapper = mapper;
            _ctx = ctx;
        }

        public async Task<IReadOnlyList<EmployeeDTO>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            var allEmployees = await _ctx.Employees.GetAllAsync();
            var Data = _mapper.Map<List<EmployeeDTO>>(allEmployees);
            return Data;
        }
    }
}
