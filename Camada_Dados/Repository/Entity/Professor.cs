using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Camada_Dados.Repository.Entity
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public long CPF { get; set; }
        public bool Ativo { get; set; }
    }
}
