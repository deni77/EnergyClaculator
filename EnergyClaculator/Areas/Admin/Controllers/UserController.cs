using EnergyCalculator.Areas.Admin.Models.User;
using EnergyCalculator.Core;
using EnergyCalculator.Core.Contracts.Admin;
using EnergyCalculator.Core.Services.Admin;
using EnergyCalculator.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EnergyCalculator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        private readonly SignInManager<ApplicationUser> signInManager;

        private readonly IUserService userService;
        public UserController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager,
                               IUserService userService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userService=userService;
            }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("All", "Ingredient", new { area = "" });
            }

            var model = new RegisterViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser()
            {
                Email = model.Email,
                UserName = model.UserName
            };

            var result = await userManager.CreateAsync(user, model.Password);


            if (result.Succeeded)
            {// ako sled register трябва да логваме User
             // await signInManager.SignInAsync(user, isPersistent: false);
             // return RedirectToAction("All", "Movies");

                 await userService.AddToRoleUser(user);

                TempData[MessageConstant.SuccessMessage] = "You are registered in the system !";

                return RedirectToAction("Login", "User", new { area = "Admin" });
            }

            foreach (var err in result.Errors)
            {
                ModelState.AddModelError("", err.Description);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("All", "Ingredient", new { area = "" });
                // return RedirectToAction("Index", "Home");
            }

            var model = new LoginViewModel() { };

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

           
            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                //if (result.Succeeded)
                //{
                //    return RedirectToAction("All", "BillLading",new { area=""});
                //}
                if (result.Succeeded && await userManager.IsInRoleAsync(user, "Admin"))
                {
                    return RedirectToAction("Index", "Admin", new { area = "Admin" });
                }
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Ingredient", new { area = "" });
                    //return RedirectToAction("All", "Ingredient", new { area = "" });
                }
            }

            ModelState.AddModelError("", "Invalid login !");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            TempData[MessageConstant.SuccessMessage] = "You are logout :)";

            return RedirectToAction("Index", "Home", new { area = "" });
        }

       

        }
}
