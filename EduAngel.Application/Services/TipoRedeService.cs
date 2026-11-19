using EduAngel.Domain.Entities;
using EduAngel.Domain.Interfaces;

namespace EduAngel.Application.Services
{
    public class TipoRedeService
    {
        private readonly ITipoRedeRepository _repository;

        public TipoRedeService(ITipoRedeRepository repository)
        {
            ArgumentNullException.ThrowIfNull(repository);
            _repository = repository;
        }

        public Task<IReadOnlyList<TipoRede>> ListarAsync()
        {
            return _repository.ListarAsync();
        }

        public Task<TipoRede?> ObterPorIdAsync(int id)
        {
            ValidarId(id);

            return _repository.ObterPorIdAsync(id);
        }

        public async Task<int> AdicionarAsync(TipoRede tipoRede)
        {
            Validar(tipoRede);

            int id = await _repository.AdicionarAsync(tipoRede);

            tipoRede.Id = id;

            return id;
        }

        public async Task AtualizarAsync(TipoRede tipoRede)
        {
            Validar(tipoRede);
            ValidarId(tipoRede.Id);

            var existente =
                await _repository.ObterPorIdAsync(tipoRede.Id);

            if (existente is null)
            {
                throw new InvalidOperationException(
                    "O tipo de rede não foi encontrado.");
            }

            await _repository.AtualizarAsync(tipoRede);
        }

        private static void Validar(TipoRede tipoRede)
        {
            ArgumentNullException.ThrowIfNull(tipoRede);

            if (string.IsNullOrWhiteSpace(tipoRede.Nome))
            {
                throw new ArgumentException(
                    "Informe o nome do tipo de rede.");
            }

            string nome = tipoRede.Nome.Trim();

            if (nome.Length > 100)
            {
                throw new ArgumentException(
                    "O nome deve ter no máximo 100 caracteres.");
            }

            tipoRede.Nome = nome;
        }

        private static void ValidarId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(
                    "O identificador deve ser maior que zero.");
            }
        }
    }
}