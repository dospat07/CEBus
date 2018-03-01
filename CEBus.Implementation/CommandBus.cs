
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
    public class CommandBus : ICommandBus
    {
        private readonly IDependencyResolver resolver;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resolver"></param>
        public CommandBus(IDependencyResolver resolver)
        {
            this.resolver = resolver;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TCommand"></typeparam>
        /// <param name="command"></param>
        public void Execute<TCommand>(TCommand command) where TCommand : ICommand
        {
            if (command != null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            var handler = (ICommandHandler<TCommand>)resolver.GetService(typeof(ICommandHandler<TCommand>));        
            handler?.Handle(command);
        }
    }
}
