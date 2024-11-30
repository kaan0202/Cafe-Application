using Application.UnitOfWork.Core;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitOfWork.Context.Database
{
    public interface IEfCoreDb:IInjectable
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollBackTransactionAsync();
        Task CreateSavePointAsync(string savepointName);
        Task RollBackSavePointAsync(string savepointName);
    }
}
