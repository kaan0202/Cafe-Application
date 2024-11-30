using Application.Abstraction.Services.App;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitOfWork.Context.App
{
    public interface IAppContext : IInjectable
    {
        public IUserService UserService { get; }
    }
}
