using System;

namespace WebAPI_FAM.Domain.Models
{
    class ItensPedido
    {
        public Produto ProdutoId { get; set; }
        public Pedido PedidoId { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
