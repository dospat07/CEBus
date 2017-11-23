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
    public interface ICommand
    {

    }
    /// <summary>
    /// 
    /// </summary>
    public interface ICommandHandler
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    public interface ICommandHandler<TCommand> : ICommandHandler where TCommand : ICommand
    {
        /// <summary>
        /// /
        /// </summary>
        /// <param name="command"></param>
        void Handle(TCommand command);
    }

  
}
