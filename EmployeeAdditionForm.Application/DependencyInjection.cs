using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAdditionForm.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjection).Assembly;

            services.AddMediatR(configuration =>
                configuration.RegisterServicesFromAssembly(assembly));

            // Register Fluent Validation service
            services.AddFluentValidation(conf => {
                conf.DisableDataAnnotationsValidation = true;
                conf.ImplicitlyValidateChildProperties = true;
                //conf.ValidatorOptions.CascadeMode = FluentValidation.CascadeMode.Stop;
                conf.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });
          //  services.AddValidatorsFromAssembly(assembly);

            // Register AutoMapper Services
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
