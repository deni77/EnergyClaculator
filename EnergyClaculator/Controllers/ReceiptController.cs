using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Mvc;

namespace EnergyClaculator.Controllers
{
    public class ReceiptController : Controller
    {
        private readonly IRepository repo;

        private readonly IReceiptService receiptService;

        public ReceiptController(IRepository repo, IReceiptService receiptService)
        {
            this.repo = repo;
            this.receiptService = receiptService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await receiptService.All();

            return View(products);
        }
    }
}
