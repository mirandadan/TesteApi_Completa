using System;
using System.Collections.Generic;
using System.Text;

namespace Camada_Negocio.Model
{
    public class ProfessorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public long CPF { get; set; }
        public bool Ativo { get; set; }
    }
}
