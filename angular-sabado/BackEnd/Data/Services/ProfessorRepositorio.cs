using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Data.Interfaces;
using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.Data.Services
{
    public class ProfessorRepositorio : IProfessorRepositorio
    {
        private readonly DataContext _contexto;

        public ProfessorRepositorio(DataContext contexto)
        {
            _contexto = contexto;
        }
        public   Task<Professor> ObterPeloId(int professorId, bool incluirAluno)
        {
            IQueryable<Professor> consulta = _contexto.Professor;
            if (incluirAluno)
            {
                consulta = consulta.Include(a => a.Disciplinas)
                                    .ThenInclude(ad => ad.AlunoDisciplinas)
                                    .ThenInclude(d => d.Aluno);
            }
        }

        public  Task<IEnumerable<Professor>> ObterTodos(bool incluirAluno)
        {
            throw new System.NotImplementedException();
        }

        public  Task<IEnumerable<Professor>> ObterTodosPeloAlunoId(int alunoId, bool incluirDisciplina)
        {
            throw new System.NotImplementedException();
        }
    }
}