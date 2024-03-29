﻿using System;

namespace Pizzaria_53.Domain.Models
{
    abstract class BaseModel
    {
        public Guid Id { get; protected set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
