using NET_Lanches.Models;

namespace NET_Lanches.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesFavoritos { get; }
        Lanche GetLancheById(int lancheId);
    }
}
