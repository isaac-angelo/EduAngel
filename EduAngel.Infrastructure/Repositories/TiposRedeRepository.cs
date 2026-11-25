using EduAngel.Domain.Entities;
using EduAngel.Domain.Interfaces;
using MySqlConnector;

namespace EduAngel.Infrastructure.Repositories
{
    public class TiposRedeRepository : ITipoRede
    {
        private readonly string _connectionString;

        public TiposRedeRepository(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException(
                    "A conexão com o banco deve ser informada.",
                    nameof(connectionString));
            }

            _connectionString = connectionString;
        }

        public async Task<IReadOnlyList<TiposRedes>> ListarAsync()
        {
            var tiposRede = new List<TiposRedes>();

            await using var conexao =
                new MySqlConnection(_connectionString);

            await conexao.OpenAsync();

            const string sql = """
                SELECT id, nome, ativo
                FROM tipos_rede
                ORDER BY nome;
                """;

            await using var comando = new MySqlCommand(sql, conexao);
            await using var leitor = await comando.ExecuteReaderAsync();

            while (await leitor.ReadAsync())
            {
                tiposRede.Add(new TiposRedes
                {
                    Id = leitor.GetInt32("id"),
                    Nome = leitor.GetString("nome")
                });
            }

            return tiposRede;
        }

        public async Task<TiposRedes?> ObterPorIdAsync(int id)
        {
            await using var conexao =
                new MySqlConnection(_connectionString);

            await conexao.OpenAsync();

            const string sql = """
                SELECT id, nome, ativo
                FROM tipos_rede
                WHERE id = @id;
                """;

            await using var comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@id", id);

            await using var leitor = await comando.ExecuteReaderAsync();

            if (await leitor.ReadAsync())
            {
                return new TiposRedes
                {
                    Id = leitor.GetInt32("id"),
                    Nome = leitor.GetString("nome"),
                };
            }

            return null;
        }

        public async Task<int> AdicionarAsync(TiposRedes tipoRede)
        {
            await using var conexao =
                new MySqlConnection(_connectionString);

            await conexao.OpenAsync();

            const string sql = """
                INSERT INTO tipos_rede (nome, ativo)
                VALUES (@nome, @ativo);
                """;

            await using var comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", tipoRede.Nome);

            await comando.ExecuteNonQueryAsync();

            return checked((int)comando.LastInsertedId);
        }

        public async Task AtualizarAsync(TiposRedes tipoRede)
        {
            await using var conexao =
                new MySqlConnection(_connectionString);

            await conexao.OpenAsync();

            const string sql = """
                UPDATE tipos_rede
                SET nome = @nome,
                    ativo = @ativo
                WHERE id = @id;
                """;

            await using var comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@id", tipoRede.Id);
            comando.Parameters.AddWithValue("@nome", tipoRede.Nome);

            await comando.ExecuteNonQueryAsync();
        }
    }
}