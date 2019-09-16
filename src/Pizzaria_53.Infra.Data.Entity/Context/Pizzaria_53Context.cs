using Microsoft.EntityFrameworkCore;
using Pizzaria_53.Domain.Models;
using Pizzaria_53.Infra.Data.Entity.Mappings;

namespace Pizzaria_53.Infra.Data.Entity.Context
{
    public class Pizzaria_53Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public DbSet<ItensPedido> ItensPedidos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Pizzaria> Pizzarias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TamanhoProduto> TamanhoProdutos { get; set; }
        public DbSet<TipoProduto> TipoProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new FormaPagamentoMap());
            modelBuilder.ApplyConfiguration(new ItensPedidoMap());
            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new PizzariaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new StatusMap());
            modelBuilder.ApplyConfiguration(new TamanhoProdutoMap());
            modelBuilder.ApplyConfiguration(new TipoProdutoMap());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
