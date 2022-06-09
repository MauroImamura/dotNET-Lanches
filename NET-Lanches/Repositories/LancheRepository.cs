using Microsoft.EntityFrameworkCore;
using NET_Lanches.Context;
using NET_Lanches.Models;
using NET_Lanches.Repositories.Interfaces;

namespace NET_Lanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesFavoritos => _context.Lanches
                                                        .Where(l => l.IsLanchePreferido)
                                                        .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
