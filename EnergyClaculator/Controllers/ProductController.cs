using EnergyCalculator.Core;
using EnergyCalculator.Core.Constants;
using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Core.Models.Product;
using EnergyCalculator.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EnergyClaculator.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository repo;

        private readonly IProductService productService;

        public ProductController(IRepository repo, IProductService productService)
        {
            this.repo = repo;
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await productService.All();

            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ProductViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await productService.Exists(model.Name) == true)
            {
                TempData[MessageConstant.ErrorMessage] = "Product with this name is already added !";

                return RedirectToAction("Add", "Product", new { area = "" });
            }

            int id = await productService.Add(model);

            TempData[MessageConstant.SuccessMessage] = "New product is added !";

            return RedirectToAction(nameof(Index), new { id });
        }
    }
}
