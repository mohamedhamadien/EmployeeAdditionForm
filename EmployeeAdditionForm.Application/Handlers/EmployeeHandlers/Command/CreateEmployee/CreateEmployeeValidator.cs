using EmployeeAdditionForm.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Command.CreateEmployee
{
    public class CreateEmployeeValidator : AbstractValidator<CreateEmployeeCommand>
    {
        private readonly IUnitOfWork _ctx;

        public CreateEmployeeValidator(IUnitOfWork ctx)
        {
            _ctx = ctx;

            RuleFor(x => x.Name)
                .NotNull().NotEmpty().WithMessage("Employee Name Required")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.")
                .Matches(@"^[^<>]+$").WithMessage("Employee Name Not Valid");
            
            RuleFor(x => x.RoleId)
                .NotNull().NotEmpty()
                .WithMessage("Role Id is Required")
                .Must(x => _ctx.Roles.IsExisted(x))
                .WithMessage("Role Not Found");
            
            RuleFor(x => x.Gender)
               .NotNull().NotEmpty()
               .WithMessage("Gender Required");

            RuleFor(x => x.Gender)
                .ExclusiveBetween(0, 3)
                .WithMessage("Gender not Valid select 1 for male and 2 for female");
           
            RuleFor(x => x.StartDate)
                .NotNull().NotEmpty()
                .WithMessage("Start Date Reqierd");
            
            RuleFor(x => x.Note)
               .Matches(@"^[^<>]+$").WithMessage("Note Not Valid")
                .MaximumLength(500).WithMessage("Note cannot exceed 500 characters.")
               .When(s => !string.IsNullOrEmpty(s.Note));
        }
    }
}
