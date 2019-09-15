using System;

namespace Pizzaria_53.Domain.Models
{
    public class ItensPedido
    {
        public Guid PedidoId { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
    }
}
