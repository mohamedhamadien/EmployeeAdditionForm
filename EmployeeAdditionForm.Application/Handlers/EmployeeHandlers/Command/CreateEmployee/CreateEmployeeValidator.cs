﻿using EmployeeAdditionForm.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application.Handlers.EmployeeHandlers.Command.CreateEmployee
{
    public class CreateEmployeeValidator : AbstractValidator<CreateEmployeeCommad>
    {
        private readonly IUnitOfWork _ctx;

        public CreateEmployeeValidator(IUnitOfWork ctx)
        {
            _ctx = ctx;

            RuleFor(x => x.Name)
                .NotNull().NotEmpty().WithMessage("Employee Name Required")
                .Matches(@"^[^<>]+$").WithMessage("Employee Name Not Valid");
            
            RuleFor(x => x.Gender)
               .NotNull()
               .NotEmpty().WithMessage("Gender Required");

            RuleFor(x => x.Gender).ExclusiveBetween(1, 2)
                .WithMessage("Gender not Valid select 1 for male and 2 for female");
            RuleFor(x => x.StartDate)
                .NotNull().NotEmpty().WithMessage("Start Date Reqierd");
            RuleFor(x => x.Note)
               .Matches(@"^[^<>]+$").WithMessage("Note Not Valid")
               .When(s => !string.IsNullOrEmpty(s.Note));
        }
    }
}
