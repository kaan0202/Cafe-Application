using Application.UnitOfWork.Context.Database;
using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.UnitOfWork.Context.Database
{
    public class DatabaseContext : ServiceGetter, IDatabaseContext
    {
        public DatabaseContext(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public IEfCoreDb EfCoreDbContext =>GetService<IEfCoreDb>();
    }
}
