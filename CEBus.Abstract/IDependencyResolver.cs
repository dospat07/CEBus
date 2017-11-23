using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEBus.Abstract
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDependencyResolver
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="type"></param>
     /// <returns></returns>
        object GetService(Type type);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IEnumerable<object> GetServices(Type type);
    }
}
