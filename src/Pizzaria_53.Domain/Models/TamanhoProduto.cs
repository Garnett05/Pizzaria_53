using System;

namespace Pizzaria_53.Domain.Models
{
    class TamanhoProduto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
