using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using NtinasPieShop.Models;
using NtinasPieShop.ViewModels;

namespace NtinasPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _CategoryRepository;


        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _CategoryRepository = categoryRepository;

        }
        public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;
            string? currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies
                    .OrderBy(p => p.PieId);
                currentCategory = "All pies";
            }
            else
            {
                pies = _pieRepository.AllPies
                    .Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PieId);

                currentCategory = _CategoryRepository.AllCategories
                    .FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new PieListViewModel(pies, currentCategory));
        }


        public ActionResult List()
        {
            // ViewBag.CurrentCategory = "Cheese cakes";
            // return View(_pieRepository.AllPies);
            PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies, "All pies");
            return View(pieListViewModel);
        }

        public IActionResult Details(int id)

        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);



        }
    }
}