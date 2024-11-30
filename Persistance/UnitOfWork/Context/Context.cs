using Application.UnitOfWork.Context;
using Application.UnitOfWork.Context.App;
using Application.UnitOfWork.Context.Auth;
using Application.UnitOfWork.Context.Token;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.UnitOfWork.Context
{
    public class Context : ServiceGetter, IContext
    {
        public Context(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public IAuthContext AuthContext => GetService<IAuthContext>();

        public ITokenContext TokenContext => GetService<ITokenContext>();

        public IAppContext AppContext =>GetService<IAppContext>();
    }
}
