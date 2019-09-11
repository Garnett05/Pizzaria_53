namespace Pizzaria_53.Domain.Models
{
    class Pizzaria : BaseModel
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string EMail { get; set; }
        public Endereco EnderecoId { get; set; }
    }
}
