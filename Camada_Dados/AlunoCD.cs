using Camada_Dados.Repository.Entity;
using System;
using System.Linq;
using TesteAPI_Completa.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camada_Dados
{
    public class AlunoCD
    {
        public Aluno AlunosPorID(int Id)
        {
            var db = new MeuDbContext();
            Aluno p = new Aluno();

            p = db.Alunos.FirstOrDefault(x => x.Id == Id);

            return p;
        }
        public List<Aluno> MostrarAlunos()
        {
            var db = new MeuDbContext();
            return db.Alunos.ToList();
        }

        public Aluno SalvarAluno(Aluno aluno)
        {
            var db = new MeuDbContext();
            db.Add(aluno);
            db.SaveChanges();
            return aluno;
        }


        public void DeletarAluno(int Id)
        {
            var db = new MeuDbContext();
            Aluno aluno = new Aluno();
            db.Remove(aluno);
            db.SaveChanges();
        }
    }
}
