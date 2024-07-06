using Area52Lanches.Models;

namespace Area52Lanches.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches {get;}
        IEnumerable<Lanche> LanchesPreferidos {get; }
        Lanche GetLancheById(int lancheId);
    }
}