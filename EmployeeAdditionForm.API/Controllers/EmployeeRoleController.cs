using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Command.CreateEmployee;
using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Queries.GetAllEmployees;
using EmployeeAdditionForm.Application.Handlers.EmployeeRolesHandlers.Queries.GatAllRoles;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdditionForm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeRoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeRoleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllRolesQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeRoleCommad command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
