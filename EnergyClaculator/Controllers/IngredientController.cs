using Microsoft.AspNetCore.Mvc;

namespace EnergyCalculator.Controllers
{
    public class IngredientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
