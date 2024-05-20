using EmployeeAdditionForm.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Command.CreateEmployee
{
    public class CreateEmployeeRoleValidator : AbstractValidator<CreateEmployeeRoleCommad>
    {
        private readonly IUnitOfWork _ctx;

        public CreateEmployeeRoleValidator(IUnitOfWork ctx)
        {
            _ctx = ctx;

            RuleFor(x => x.Name)
                .NotNull().NotEmpty().WithMessage("Employee Name Required")
                .Matches(@"^[^<>]+$").WithMessage("Employee Name Not Valid");
        }
    }
}
