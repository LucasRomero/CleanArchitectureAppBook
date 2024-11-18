using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreApplication.Abstractions.Behaviors;

namespace BookStoreApplication
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {

            // Registrar MediatR y Pipeline Behaviors
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);

                config.AddOpenBehavior(typeof(ValidationBehavior<,>));

            });

            // Registrar FluentValidation
            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);
            
            // Registrar AutoMapper
            services.AddAutoMapper(typeof(DependencyInjection).Assembly);


            return services;
        }
    }
}
