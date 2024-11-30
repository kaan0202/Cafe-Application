using Application.UnitOfWork.Context;
using Application.UnitOfWork.Context.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IDatabaseContext DatabaseContext { get; }
        public IContext Context { get; }
    }
}
