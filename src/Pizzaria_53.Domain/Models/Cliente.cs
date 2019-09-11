namespace Pizzaria_53.Domain.Models
{
    class Cliente : BaseModel
    {
        public string Nome { get; set; }
        public string EMail { get; set; }
        public int Telefone { get; set; }
        public Endereco EnderecoId { get; set; }
    }
}
