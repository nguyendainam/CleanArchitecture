using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace HR.LeaveManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices (this IServiceCollection services) 
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    } 
}
