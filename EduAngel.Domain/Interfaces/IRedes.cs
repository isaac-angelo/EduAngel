using EduAngel.Domain.Entities;

namespace EduAngel.Domain.Interfaces
{
    public interface IRedes
    {
        Task<IReadOnlyList<Redes>> ListarAsync();
        Task<Redes?> ObterPorIdAsync(int id);
        Task<int> AdicionarAsync(Redes rede);
        Task AtualizarAsync(Redes rede);
    }
}
