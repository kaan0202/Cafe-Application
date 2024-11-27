using Application.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services.Auth
{
    public interface IRoleService:IInjectable
    {
        void CreateAdminRole();
        void CreateUserRole(string userName, string roleName);
    }
}
