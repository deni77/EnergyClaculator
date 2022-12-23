using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Mvc;

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
    }
}
