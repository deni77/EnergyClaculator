using EnergyCalculator.Core;
using EnergyCalculator.Core.Constants;
using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Core.Models.Ingredient;
using EnergyCalculator.Core.Services;
using EnergyCalculator.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

        public async Task<IActionResult> MyIngredients()
        {
            var currentUserID = getCurrentUserId();

            var ingredients = await ingredientDervice.MyIngredients(currentUserID);

            return View(ingredients);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new IngredientViewModel()
            {
                Products = await ingredientDervice.AllProducts(),
                Receipts = await ingredientDervice.AllReceipts()
            };

            TempData["UserId"] = getCurrentUserId();

            return View(model);
        }

         [HttpGet]
        public async Task<IActionResult> SearchByReceipt()
        { 
             var model = new IngredientBySearchViewModel()
            {
                Receipts = await ingredientDervice.AllReceipts()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SearchByReceipt(IngredientBySearchViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Receipts = await ingredientDervice.AllReceipts();
                return View(model);
            }

            var ingredients = await ingredientDervice.SearchIngredientByReceipt(model.ReceiptId);

            return View("IngredientsByReceipt",ingredients);
        }
            
        [HttpPost]
        public async Task<IActionResult> Add(IngredientViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Products = await ingredientDervice.AllProducts();
                model.Receipts = await ingredientDervice.AllReceipts();
                return View(model);
            }

            if (await ingredientDervice.ExistsIngredient(model.ProductId, model.ReceiptId) == true)
            {
                TempData[MessageConstant.ErrorMessage] =
                            "Ingredient with this product and this receipt is already added !";
                return RedirectToAction("Add", "Ingredient", new { area = "" });
            }

            double TotalCalories = await ingredientDervice.CalculateTotalCaloriesByProduct(model.ProductId, model.QuantityForIngredient);

            model.TotalCalories = TotalCalories;


            int id = await ingredientDervice.Add(model);

            TempData[MessageConstant.SuccessMessage] = "New Ingredient is added !";

            if (User.IsInRole("Admin"))
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(MyIngredients));
        }

        public string getCurrentUserId()
        {
            ClaimsPrincipal currentUser = this.User;
            return currentUser?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
