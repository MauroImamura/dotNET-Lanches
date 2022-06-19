using Microsoft.AspNetCore.Mvc;
using NET_Lanches.Models;
using NET_Lanches.Repositories.Interfaces;
using NET_Lanches.ViewModel;

namespace NET_Lanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancherepository;

        public LancheController(ILancheRepository lancherepository)
        {
            _lancherepository = lancherepository;
        }

        public IActionResult List(string categoria)
        {

            ViewData["Título"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;

            //var lanches = _lancherepository.Lanches;
            //var totalLanches = lanches.Count();

            //ViewBag.Total = "Total de Lanches";
            //ViewBag.TotalLanches = totalLanches;
            //return View(lanches);
            //var lanchesListViewModel = new LancheListViewModel();
            //lanchesListViewModel.Lanches = _lancherepository.Lanches;
            //lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            //return View(lanchesListViewModel);

            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if(string.IsNullOrEmpty(categoria))
            {
                lanches = _lancherepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                lanches = _lancherepository.Lanches
                          .Where(l => l.Categoria.CategoriaNome.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                          .OrderBy(c => c.LancheNome);
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);
        }

        public IActionResult Details(int lancheId)
        {
            var lanche = _lancherepository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
            return View(lanche);
        }
    }
}
