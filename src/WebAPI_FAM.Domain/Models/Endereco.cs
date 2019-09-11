using System;

namespace WebAPI_FAM.Domain.Models
{
    class Endereco
    {
        public Guid Id { get; protected set; }
        public string Logadouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
