using Application.Abstraction.Services.Auth;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitOfWork.Context.Auth
{
    public interface IAuthContext:IInjectable
    {
        public IAuthorizationService AuthorizationService { get;}
        public IRoleService RoleService { get;}
    }
}
