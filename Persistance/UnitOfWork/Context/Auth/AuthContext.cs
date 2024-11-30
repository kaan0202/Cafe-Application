using Application.Abstraction.Services.Auth;
using Application.UnitOfWork.Context.Auth;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.UnitOfWork.Context.Auth
{
    public class AuthContext : ServiceGetter, IAuthContext
    {
        public AuthContext(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public IAuthorizationService AuthorizationService => GetService<IAuthorizationService>();

        public IRoleService RoleService => GetService<IRoleService>();
    }
}
