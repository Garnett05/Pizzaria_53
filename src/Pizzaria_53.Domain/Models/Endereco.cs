﻿namespace Pizzaria_53.Domain.Models
{
    public class Endereco : BaseModel
    {
        public string Logadouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}
