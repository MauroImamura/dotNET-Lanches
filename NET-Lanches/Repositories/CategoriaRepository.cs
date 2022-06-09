using NET_Lanches.Context;
using NET_Lanches.Models;
using NET_Lanches.Repositories.Interfaces;

namespace NET_Lanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
