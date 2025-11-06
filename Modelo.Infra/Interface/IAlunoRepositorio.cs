using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Domain;

namespace Modelo.Infra.Interface
{
    public interface IAlunoRepositorio
    {
        Task<Aluno> BuscarAluno(int id);
    }
}
