using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelo.Domain;
using Modelo.Infra.Interface;

namespace Modelo.Infra.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly DbConnectionFactory _connectionFactory;

        public AlunoRepositorio(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<Aluno> BuscarAluno(int id)
        {
            using var connection = _connectionFactory.CreateConnection();

            string sql = "Select * from Aluno Where Id = @Id";

            var aluno = await connection.QueryFirstOrDefaultAsync<Aluno>(sql,
                new { Id = id });

            return aluno;
        }
    }
}
