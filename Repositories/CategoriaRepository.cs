using Area52Lanches.Models;
using Area52Lanches.Context;
using Area52Lanches.Repositories.Interfaces;

namespace Area52Lanches.Repositories
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
