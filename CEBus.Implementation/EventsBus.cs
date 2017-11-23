
using CEBus.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEBus.Implementation
{
    /// <summary>
    /// 
    /// </summary>
    public class EventsBus : IEventsBus
    {
        private readonly IDependencyResolver resolver;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resolver"></param>
        public EventsBus(IDependencyResolver resolver)
        {
            this.resolver =  resolver;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="event"></param>
        public void Publish<TEvent>(TEvent @event) where TEvent : IEvent
        {
            var handlers = resolver.GetServices(typeof(IEventHandler<TEvent>));
            foreach (var handler in handlers)
            {
                ((IEventHandler<TEvent>)handler).Handle(@event);
            }
        }
      
    }
}
