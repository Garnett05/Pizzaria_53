using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class TamanhoProdutoMap : IEntityTypeConfiguration<TamanhoProduto>
    {
        public void Configure(EntityTypeBuilder<TamanhoProduto> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
