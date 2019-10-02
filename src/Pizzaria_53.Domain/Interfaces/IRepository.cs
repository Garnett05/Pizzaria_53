using System;
using System.Linq;

namespace Pizzaria_53.Domain.Interfaces
{
    public interface IRepository<TModel> : IDisposable
    {
        void Incluir(TModel obj);

        TModel Consultar(Guid id);

        IQueryable<TModel> Listar();

        void Alterar(TModel obj);

        void Remover(Guid id);
        //teste
    }
}
