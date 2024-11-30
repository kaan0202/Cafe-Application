using Application.UnitOfWork.Context.App;
using Application.UnitOfWork.Context.Auth;
using Application.UnitOfWork.Context.Token;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitOfWork.Context
{
    public interface IContext:IInjectable
    {
        public IAuthContext AuthContext { get; }
        public ITokenContext TokenContext { get;}
        public IAppContext AppContext { get; }
    }
}
