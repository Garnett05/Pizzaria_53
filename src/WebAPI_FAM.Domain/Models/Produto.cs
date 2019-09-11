using System;

namespace WebAPI_FAM.Domain.Models
{
    class Produto
    {
        public Guid Id { get; protected set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public TamanhoProduto TamanhoProdutoId { get; set; }
        public TipoProduto TipoProdutoId { get; set; }
        public DateTime? Datainclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
