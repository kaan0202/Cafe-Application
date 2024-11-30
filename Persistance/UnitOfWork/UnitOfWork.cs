using Application.UnitOfWork;
using Application.UnitOfWork.Context;
using Application.UnitOfWork.Context.Database;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.UnitOfWork
{
    public class UnitOfWork : ServiceGetter,IUnitOfWork
    {
        public UnitOfWork(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public IDatabaseContext DatabaseContext => GetService<IDatabaseContext>();

        public IContext Context => GetService<IContext>();
    }
}
