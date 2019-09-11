namespace Pizzaria_53.Domain.Models
{
    public class Produto : BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public TamanhoProduto TamanhoProdutoId { get; set; }
        public TipoProduto TipoProdutoId { get; set; }
    }
}
