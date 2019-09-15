using System.Collections.Generic;

namespace Pizzaria_53.Domain.Models
{
    public class Produto : BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public TamanhoProduto TamanhoProduto { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public List<ItensPedido> ListaItensPedidos { get; set; }
    }
}
