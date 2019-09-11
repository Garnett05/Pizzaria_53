using Microsoft.EntityFrameworkCore;
using Pizzaria_53.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria_53.Infra.Data.Entity.Context
{
    class Pizzaria_53Context : DbContext
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
    }
}
