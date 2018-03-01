using CEBus.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CEBus.Implementation
{
    /// <summary>
    /// 
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddCEBus(this IServiceCollection services)
        {
            services.AddSingleton<IDependencyResolver, DependencyResolver>();
            services.AddSingleton<ICommandBus, CommandBus>();
            return services;
        }
    }
}
