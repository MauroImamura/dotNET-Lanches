using Microsoft.AspNetCore.Mvc;
using NET_Lanches.Repositories.Interfaces;

namespace NET_Lanches.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoryRepository;

        public CategoriaMenu(ICategoriaRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoryRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }
    }
}
