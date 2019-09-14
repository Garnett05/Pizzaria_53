using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class ItensPedidoMap : IEntityTypeConfiguration<ItensPedido>
    {
        public void Configure(EntityTypeBuilder<ItensPedido> builder)
        {
            builder.ToTable("ITENS_PEDIDO");

            builder
                .HasOne(a => a.PedidoId)
                .WithMany()
                .HasForeignKey(f => f.PedidoId);

            builder
                .HasOne(a => a.ProdutoId)
                .WithMany()
                .HasForeignKey(f => f.ProdutoId);

        }
    }
}
