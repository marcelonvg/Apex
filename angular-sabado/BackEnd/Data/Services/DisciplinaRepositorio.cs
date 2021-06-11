using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Data.Interfaces;
using BackEnd.Models;
using System.Collections.Generic;

namespace BackEnd.Data.Services
{
    public class DisciplinaRepositorio : IDisciplinaRepositorio
    {
        private readonly DataContext _contexto;

        public DisciplinaRepositorio(DataContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<Disciplina> ObterPeloId(int disciplinaId, bool incluirDisciplina)
        {
             IQueryable<Aluno> consulta = _contexto.Aluno;
            if (incluirDisciplina)
            {
                consulta = consulta.Include(a => a.AlunosDisciplinas)
                                    .ThenInclude( ad => ad.Disciplina)
                                    .ThenInclude( d => d.Professor);
            }
            
            consulta = consulta.AsNoTracking()
                                        .OrderBy(a => a.id)
                                        .Where(a => a.id == disciplinaId);

        }
        public async Task<IEnumerable<Disciplina>> ObterTodos(bool incluirDisciplina)
        {
           IQueryable<Aluno> consulta = _contexto.Aluno;
            if (incluirDisciplina)
            {
                consulta = consulta.Include(a => a.AlunosDisciplinas)
                                    .ThenInclude( ad => ad.Disciplina)
                                    .ThenInclude( d => d.Professor);
            }
            
            consulta = consulta.AsNoTracking().OrderBy(a => a.id);

        }
    }
}