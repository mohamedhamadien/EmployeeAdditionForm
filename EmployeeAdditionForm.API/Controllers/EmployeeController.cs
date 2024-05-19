using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Command.CreateEmployee;
using EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Queries.GetAllEmployees;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdditionForm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetAllEmployeeQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeCommad command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
