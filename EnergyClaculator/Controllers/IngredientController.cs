using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Mvc;

namespace EnergyClaculator.Controllers
{
    public class IngredientController : Controller
    {
         private readonly IRepository repo;

        private readonly IIngredientService ingredientDervice;

        public IngredientController(IRepository repo, IIngredientService ingredientDervice)
        {
            this.repo = repo;
            this.ingredientDervice = ingredientDervice;
        }

        public async Task<IActionResult> Index()
        {
            var ingredients = await ingredientDervice.All();

            return View(ingredients);
        }
    }
}
