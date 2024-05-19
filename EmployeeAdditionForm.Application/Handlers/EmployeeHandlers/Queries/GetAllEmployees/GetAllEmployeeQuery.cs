﻿using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Queries.GetAllEmployees
{
    public class GetAllEmployeeQuery : IRequest<IReadOnlyList<EmployeeDTO>>
    {
       
    }
}
