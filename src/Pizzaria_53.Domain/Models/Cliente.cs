using System.Collections.Generic;

namespace Pizzaria_53.Domain.Models
{
    public class Cliente : BaseModel
    {
        public string Nome { get; set; }
        public string EMail { get; set; }
        public int Telefone { get; set; }
        public IEnumerable<Endereco> ListaEnderecos { get; set; }
    }
}
