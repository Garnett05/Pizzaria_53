using System;

namespace WebAPI_FAM.Domain.Models
{
    class TipoProduto
    {
        public Guid Id { get; protected set; }
        public string Descricao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
