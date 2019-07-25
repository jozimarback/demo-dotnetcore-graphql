using System;
using System.Collections.Generic;

namespace DemoDotNetCoreGraphQL.Infra
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
