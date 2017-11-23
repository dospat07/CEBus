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
    public interface IEventsBus
        {/// <summary>
         /// 
         /// </summary>
         /// <typeparam name="TEvent"></typeparam>
         /// <param name="event"></param>
        void Publish<TEvent>(TEvent @event) where TEvent : IEvent;

    }
}
