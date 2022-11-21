using Camada_Dados.Repository.Entity;
using System.Linq;
using TesteAPI_Completa.Data;
using System.Collections.Generic;


namespace Camada_Dados
{
    public class ProfessorCD
    {
        public List<Professor> ObterProfessores()
        {
            var db = new MeuDbContext();
            return db.Professores.ToList();
        }
        
        public Professor ObterPorId(int Id)
        {
            var banco = new MeuDbContext();
            Professor p = new Professor();

            p = banco.Professores.FirstOrDefault(x => x.Id == Id);
            return p;
        }

        public void DeletarProfessor(int Id)
        {
            var banco = new MeuDbContext();
            Professor p = new Professor();
            p = banco.Professores.FirstOrDefault(x => x.Id == Id);

            banco.Professores.Remove(p);
            banco.SaveChanges();

        }

        public void AdicionarProfessor(Professor professor)
        {
            var banco = new MeuDbContext();
            Professor p = new Professor();

            banco.Add(professor);
            banco.SaveChanges();
        }
    }
}
