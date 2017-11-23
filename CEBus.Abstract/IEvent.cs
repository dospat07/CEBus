using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEBus.Abstract
{   /// <summary>
/// 
/// </summary>
    public interface IEvent
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public interface IEventHandler
    {

    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    public interface IEventHandler<TEvent> : IEventHandler where TEvent : IEvent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="event"></param>
        void Handle(TEvent @event);
    }
}
