using Camada_Dados.Repository.Entity;
using System;
using System.Collections.Generic;

namespace Camada_Negocio
{
    public class ProfessorCN
    {
        private Camada_Dados.ProfessorCD _CD;

        public ProfessorCN()
        {
            _CD = new Camada_Dados.ProfessorCD();
        }

        public List<Professor> ObterProfessores()
        {
            return _CD.ObterProfessores();
        }

        public Professor ObterPorId(int Id)
        {
            if (Id <= 0) throw new Exception("Id não encontrado.");

            return _CD.ObterPorId(Id);
        }

        public void DeletarProfessor(int Id)
        {
            if (Id <= 0) throw new Exception("Id não encontrado.");

            _CD.DeletarProfessor(Id);
        }

        public void AdicionarProfessor(Professor professor)
        {
            Professor p = new Professor();
            if (p.DataNascimento.AddYears(18) < DateTime.Now) throw new Exception("Não é possível cadastrar um professor menor que 18 anos.");
            if (p.Id <= 0) throw new Exception("Id inválido!");
            if (p.Nome == string.Empty) throw new Exception("O campo {0} não pode estar vazio");

            _CD.AdicionarProfessor(professor);
        }
    }
}
