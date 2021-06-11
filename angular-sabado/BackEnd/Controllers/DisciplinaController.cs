using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackEnd.Data.Interfaces;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaRepositorio _disciplinaRepositorio;
        private readonly IRepositorio _repositorio;
        public DisciplinaController(IDisciplinaRepositorio disciplinaRepositorio, IRepositorio repositorio)
        {
            _disciplinaRepositorio = disciplinaRepositorio;
            _repositorio = repositorio;
        }
    	
        [HttpGet]
        public async Task<ActionResult> ObterTodos()
        {
            try
            {
                var listadisciplinas = await _disciplinaRepositorio.obterTodos(incluirDisciplina : true);
            }
            catch (Exception ex)
            {
                
                return BadRequest($"Ao Obter todas as Disciplinas, ocorreu o erro: {ex.Message}");
            }
        }

        [HttpGet ("id={id}")]

        public async Task<IActionResult> ObterPeloId(int id)
        {
            try
            {
                var disciplina = await _disciplinaRepositorio.ObterPeloId( id, incluirDisciplina : true);
            }
            catch (Exception ex)
            {
                
                return BadRequest($"Ao Obter o ID da disciplina, ocorreu o erro: {ex.Message}");
            }
        }
    }
}