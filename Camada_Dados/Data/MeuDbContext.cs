using Camada_Dados;
using Camada_Dados.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAPI_Completa.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext()
        {

        }
        public MeuDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Professor> Professores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=.;Initial Catalog=Test_EnglishClasses;Integrated Security=True");
        }
    }
}
