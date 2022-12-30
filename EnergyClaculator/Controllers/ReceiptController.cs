using EnergyCalculator.Core;
using EnergyCalculator.Core.Contracts;
using EnergyCalculator.Core.Models.Product;
using EnergyCalculator.Core.Models.Receipt;
using EnergyCalculator.Core.Services;
using EnergyCalculator.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using EnergyCalculator.Core.Constants;

namespace EnergyClaculator.Controllers
{
    [Authorize]
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

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ReceiptViewModel();

            var currentUserID = getCurrentUserId();

            TempData["UserId"] = currentUserID;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ReceiptViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await receiptService.Exists(model.Name) == true)
            {
                TempData[MessageConstant.ErrorMessage] = "Receipt with this name is already added !";
                return RedirectToAction("Add", "Receipt", new { area = "" });
            }



            int id = await receiptService.Add(model);

            TempData[MessageConstant.SuccessMessage] = "New receipt is added !";

            return RedirectToAction(nameof(Index), new { id });
        }

        public async Task<IActionResult> MyReceipts()
        {
            var currentUserID = getCurrentUserId();

            var ingredients = await receiptService.MyReceipts(currentUserID);

            return View(ingredients);
        }

        public string getCurrentUserId()
        {
            ClaimsPrincipal currentUser = this.User;
            return currentUser?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
