using CleanArchitecture.Application.Behaviours;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitecture.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // automapper service registry
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); 
            // fluent validation service registry
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly()); 
            // mediatR service registry
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())); 
            // trasient pipeline behaviour exception service registry
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            // trasient pipeline behaviour validation service registry
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            return services;
        }
    }
}
