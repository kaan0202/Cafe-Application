using Application.Abstraction.Handlers;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitOfWork.Context.Token
{
    public interface ITokenContext:IInjectable
    {
        public ITokenHandler TokenHandler {get;}
    }
}
