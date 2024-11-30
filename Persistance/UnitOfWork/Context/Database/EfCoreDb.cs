using Application.UnitOfWork.Context.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Persistance.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.UnitOfWork.Context.Database
{
    public class EfCoreDb :  IEfCoreDb
    {
       private readonly CafeDbContext _context;

        public EfCoreDb(CafeDbContext context)
        {
            _context = context;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync() => await _context.Database.BeginTransactionAsync();
       

        public async Task CommitTransactionAsync()
        {
            if(_context.Database.CurrentTransaction != null)
            {
                await _context.Database.CommitTransactionAsync();
            }
        }

        public async Task CreateSavePointAsync(string savepointName)
        {
            if (_context.Database.CurrentTransaction != null)
            {
                await _context.Database.CurrentTransaction.CreateSavepointAsync(savepointName);
            }
        }

        public async Task RollBackSavePointAsync(string savepointName)
        {
            if (_context.Database.CurrentTransaction != null)
            {
                await _context.Database.CurrentTransaction.RollbackToSavepointAsync(savepointName);
            }
        }

        public async Task RollBackTransactionAsync()
        {
            if (_context.Database.CurrentTransaction != null)
            {
                await _context.Database.RollbackTransactionAsync();
            }
        }
    }
}
