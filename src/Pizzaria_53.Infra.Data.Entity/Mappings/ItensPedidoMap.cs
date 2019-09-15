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
                .HasKey(c => new { c.PedidoId, c.ProdutoId });

            builder
                .HasOne(c => c.Pedido)
                .WithMany(p => p.ListaItensPedidos)
                .HasForeignKey(c => c.PedidoId);

            builder
                .HasOne(c => c.Produto)
                .WithMany(p => p.ListaItensPedidos)
                .HasForeignKey(c => c.ProdutoId);
        }
    }
}
