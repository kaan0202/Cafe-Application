using Application.Abstraction.Services.App;
using Application.UnitOfWork.Context.App;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.UnitOfWork.Context.App
{
    public class AppContext : ServiceGetter, IAppContext
    {
        public AppContext(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public IUserService UserService => GetService<IUserService>();
    }
}
