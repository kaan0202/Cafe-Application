using Application.UnitOfWork.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitOfWork.Context.Database
{
    public interface IDatabaseContext:IInjectable
    {
        public IEfCoreDb EfCoreDbContext { get; }
    }
}
