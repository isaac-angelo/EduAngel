using EduAngel.Domain.Entities;

namespace EduAngel.Domain.Interfaces
{
    public interface ITipoRede
    {
        Task<IReadOnlyList<TiposRedes>> ListarAsync();

        Task<TiposRedes?> ObterPorIdAsync(int id);

        Task<int> AdicionarAsync(TiposRedes tipoRede);

        Task AtualizarAsync(TiposRedes tipoRede);
    }
}