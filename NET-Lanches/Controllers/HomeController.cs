using Microsoft.AspNetCore.Mvc;
using NET_Lanches.Models;
using NET_Lanches.Repositories.Interfaces;
using NET_Lanches.ViewModel;
using System.Diagnostics;

namespace NET_Lanches.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository)
        {
        _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {

            var homeViewModel = new HomeViewModel
            {
                LanchesFavoritos = _lancheRepository.LanchesFavoritos
            };

            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}