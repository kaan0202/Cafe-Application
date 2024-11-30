using Application.Abstraction.Handlers;
using Application.UnitOfWork.Context.Token;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.UnitOfWork.Context.Token
{
    public class TokenContext : ServiceGetter, ITokenContext
    {
        public TokenContext(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public ITokenHandler TokenHandler => GetService<ITokenHandler>();
    }
}
