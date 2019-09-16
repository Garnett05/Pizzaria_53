using Pizzaria_53.Domain.Interfaces;
using Pizzaria_53.Infra.Data.Entity.Context;
using System;

namespace Pizzaria_53.Infra.Data.Entity.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly Pizzaria_53Context Db;

        public UnitOfWork(Pizzaria_53Context context)
        {
            Db = context;
        }

        public bool Commit()
        {
            return Db.SaveChanges() > 0;
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
