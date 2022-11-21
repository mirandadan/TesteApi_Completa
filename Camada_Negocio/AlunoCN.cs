using Camada_Dados.Repository.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Camada_Negocio.Model;
using System.Linq;

namespace Camada_Negocio
{
    public class AlunoCN
    {
        private Camada_Dados.AlunoCD _CD;
        private readonly IMapper _mapper;

        public AlunoCN(IMapper mapper)
        {
            _mapper = mapper;
            _CD = new Camada_Dados.AlunoCD();
        }

        public AlunoModel AlunosPorID(int Id)
        {
            if (Id <= 0) throw new Exception("Id inválido!");

            return _mapper.Map<AlunoModel>(AlunosPorID(Id));
        }

        public List<AlunoModel> MostrarAlunos()
        {

            return _mapper.Map<List<AlunoModel>>(_CD.MostrarAlunos());
        }

        public AlunoModel SalvarAluno(Aluno aluno)
        {
            if (aluno.Nome == string.Empty) throw new Exception("Por favor, insira o nome do aluno.");
            if (aluno.Nome.Length <= 1) throw new Exception("Nome inválido.");
            if (aluno.DataNascimento.AddYears(18) < DateTime.Now) throw new Exception("Você precisa de um responsável para a realização do cadastro.");
            if (aluno.Sobrenome == string.Empty) throw new Exception("Por favor, insira seu sobrenome.");

            _CD.SalvarAluno(aluno);

            return _mapper.Map<AlunoModel>(aluno);
        }


        public void DeletarAluno(int Id)
        {

            if (Id == null) throw new Exception("Não encontrei...");

            _CD.DeletarAluno(Id);
        }
    }
}
