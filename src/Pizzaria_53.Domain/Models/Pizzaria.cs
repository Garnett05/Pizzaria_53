using System;

namespace Pizzaria_53.Domain.Models
{
    class Pizzaria
    {
        public Guid Id { get; protected set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string EMail { get; set; }
        public Endereco EnderecoId { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
