using EduAngel.Domain.Entities;
using EduAngel.Domain.Interfaces;
using MySqlConnector;

namespace EduAngel.Infrastructure.Repositories
{
    public class TipoRedeRepository : ITipoRedeRepository
    {
        private readonly string _connectionString;

        public TipoRedeRepository(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException(
                    "A conexão com o banco deve ser informada.",
                    nameof(connectionString));
            }

            _connectionString = connectionString;
        }

        public async Task<IReadOnlyList<TipoRede>> ListarAsync()
        {
            var tiposRede = new List<TipoRede>();

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
                tiposRede.Add(new TipoRede
                {
                    Id = leitor.GetInt32("id"),
                    Nome = leitor.GetString("nome"),
                    Ativo = leitor.GetBoolean("ativo")
                });
            }

            return tiposRede;
        }

        public async Task<TipoRede?> ObterPorIdAsync(int id)
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
                return new TipoRede
                {
                    Id = leitor.GetInt32("id"),
                    Nome = leitor.GetString("nome"),
                    Ativo = leitor.GetBoolean("ativo")
                };
            }

            return null;
        }

        public async Task<int> AdicionarAsync(TipoRede tipoRede)
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
            comando.Parameters.AddWithValue("@ativo", tipoRede.Ativo);

            await comando.ExecuteNonQueryAsync();

            return checked((int)comando.LastInsertedId);
        }

        public async Task AtualizarAsync(TipoRede tipoRede)
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
            comando.Parameters.AddWithValue("@ativo", tipoRede.Ativo);

            await comando.ExecuteNonQueryAsync();
        }
    }
}