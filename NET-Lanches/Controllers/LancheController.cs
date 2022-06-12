using Microsoft.AspNetCore.Mvc;
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

        public IActionResult List()
        {

            ViewData["Título"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;

            //var lanches = _lancherepository.Lanches;
            //var totalLanches = lanches.Count();

            //ViewBag.Total = "Total de Lanches";
            //ViewBag.TotalLanches = totalLanches;
            //return View(lanches);
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancherepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);
        }
    }
}
