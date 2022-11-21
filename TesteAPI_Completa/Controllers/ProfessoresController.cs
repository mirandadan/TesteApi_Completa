using Camada_Dados.Repository.Entity;
using Camada_Negocio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private ProfessorCN _CN;

        public ProfessoresController()
        {
            _CN = new ProfessorCN();
        }

        [HttpGet("todos")]
        public List<Professor> ObterProfessores()
        {
            return _CN.ObterProfessores();
        }
        [HttpGet("{Id}")]
        public Professor ObterPorId(int Id)
        {
            return _CN.ObterPorId(Id);
        }
        [HttpDelete("deletar/{Id:int}")]
        public void DeletarProfessor(int Id)
        {
            _CN.DeletarProfessor(Id);
        }
        [HttpPost("salvar")]
        public void AdicionarProfessor(Professor professor)
        {
             _CN.AdicionarProfessor(professor);
        }
    }
}
