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
    public class DependencyResolver: IDependencyResolver
    {
        private IServiceProvider serviceProvider;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceProvider"></param>
        public DependencyResolver(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public object GetService(Type type)
        {
            return this.serviceProvider.GetService(type);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IEnumerable<object> GetServices(Type type)
        {
            return ServiceProviderServiceExtensions.GetServices(serviceProvider, type);

        }
    }
}
