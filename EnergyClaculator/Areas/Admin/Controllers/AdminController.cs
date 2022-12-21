using Microsoft.AspNetCore.Mvc;

namespace EnergyCalculator.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
