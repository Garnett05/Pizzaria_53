using System.Collections.Generic;

namespace Pizzaria_53.Domain.Models
{
    public class Pedido : BaseModel
    {
        public int Quantidade { get; set; }
        public float ValorTotal { get; set; }
        public string Descricao { get; set; }
        public Status Status { get; set; }
        public Cliente Cliente { get; set; }
        public Pizzaria Pizzaria { get; set; }
        public List<ItensPedido> ListaItensPedidos { get; set; }
        public List<FormaPagamento> ListaFormaPagamento { get; set; }

    }
}
