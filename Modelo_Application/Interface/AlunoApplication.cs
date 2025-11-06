using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Infra.Interface;

namespace Modelo.Application.Interface
{
    public class AlunoApplication : IAlunoApplication
    {

        private readonly IAlunoRepositorio _alunoRepositorio;

        public IAlunoApplication(IAlunoApplication alunoRepositorio)
        {
           _alunoRepositorio = alunoRepositorio;
        }

        public async Task<Aluno> BuscarAluno(int id)
        {

            try
            {
                return await _alunoRepositorio.BuscarAluno(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
