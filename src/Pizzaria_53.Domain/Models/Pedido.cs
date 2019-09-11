namespace Pizzaria_53.Domain.Models
{
    public class Pedido : BaseModel
    {
        public int Quantidade { get; set; }
        public float ValorTotal { get; set; }
        public string Descricao { get; set; }
        public FormaPagamento FormaPagamentoId { get; set; }
        public Status StatusId { get; set; }
        public Cliente ClienteId { get; set; }
        public Pizzaria PizzariaId { get; set; }
    }
}
