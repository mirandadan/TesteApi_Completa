using Camada_Dados.Repository.Entity;
using Camada_Negocio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI_Completa.Data;
using Camada_Negocio.Model;
using AutoMapper;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : Controller
    {
        private readonly AlunoCN _CN;
        private readonly IMapper _mapper;

        public AlunosController(IMapper mapper)
        {
            _CN = new AlunoCN(mapper);
        }

        [HttpGet("{Id:int}")]
        public AlunoModel AlunosPorID(int Id)
        {
            try
            {
                return _CN.AlunosPorID(Id);
            }
            catch (Exception ex)
            {
                NotFound(ex.Message);
                throw;
            }
        }

        [HttpGet("todos")]
        public List<AlunoModel> MostrarAlunos()
        {
            return _CN.MostrarAlunos();
        }

        [HttpPost("salvar")]
        public void SalvarAluno(Aluno aluno)
        {
            try
            {
                _CN.SalvarAluno(aluno);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
                throw;
            }
            
        }

        [HttpDelete("deletar/{Id:int}")]
        public void DeletarAluno(int Id)
        {
            try
            {
                _CN.DeletarAluno(Id);
            }
            catch (Exception ex) 
            {
                NotFound(ex.Message);
                throw;
            }    
        }
    }
}
