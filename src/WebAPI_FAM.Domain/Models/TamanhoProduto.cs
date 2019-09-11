using System;

namespace WebAPI_FAM.Domain.Models
{
    class TamanhoProduto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
