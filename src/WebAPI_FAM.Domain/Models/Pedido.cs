using System;

namespace WebAPI_FAM.Domain.Models
{
    class Pedido
    {
        public Guid Id { get; protected set; }
        public int Quantidade { get; set; }
        public float ValorTotal { get; set; }
        public string Descricao { get; set; }
        public FormaPagamento FormaPagamentoId { get; set; }
        public Status StatusId { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
