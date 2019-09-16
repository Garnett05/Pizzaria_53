using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pizzaria_53.Domain.Interfaces;
using Pizzaria_53.Domain.Models;
using Pizzaria_53.Infra.Data.Entity.Context;

namespace Pizzaria_53.Infra.Data.Entity.Repository
{
    public class Repository<TModel> : IRepository<TModel> where TModel : BaseModel
    {
        private readonly Pizzaria_53Context Db;
        protected readonly DbSet<TModel> DbSet;

        public Repository(Pizzaria_53Context context)
        {
            Db = context;
            DbSet = Db.Set<TModel>();
        }

        public void Incluir(TModel obj)
        {
            DbSet.Add(obj);
        }

        public TModel Consultar(Guid id)
        {
            return DbSet
                .AsNoTracking()
                .Include(Db.GetIncludePaths(typeof(TModel)))
                .SingleOrDefault(x => x.Id == id);
        }

        public IQueryable<TModel> Listar()
        {
            return DbSet.AsNoTracking();
        }

        public void Alterar(TModel obj)
        {
            DbSet.Update(obj);
        }

        public void Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}