using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class PizzariaMap : IEntityTypeConfiguration<Pizzaria>
    {
        public void Configure(EntityTypeBuilder<Pizzaria> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
