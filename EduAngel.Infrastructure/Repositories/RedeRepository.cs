using EduAngel.Domain.Entities;
using EduAngel.Domain.Interfaces;

namespace EduAngel.Infrastructure.Repositories
{
    public class RedeRepository : IRedes
    {
        public Task<int> AdicionarAsync(Redes rede)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync(Redes rede)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Redes>> ListarAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Redes?> ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
