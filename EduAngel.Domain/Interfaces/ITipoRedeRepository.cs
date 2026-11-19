using EduAngel.Domain.Entities;

namespace EduAngel.Domain.Interfaces
{
    public interface ITipoRedeRepository
    {
        Task<IReadOnlyList<TipoRede>> ListarAsync();

        Task<TipoRede?> ObterPorIdAsync(int id);

        Task<int> AdicionarAsync(TipoRede tipoRede);

        Task AtualizarAsync(TipoRede tipoRede);
    }
}