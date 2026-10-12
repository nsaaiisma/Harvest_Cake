using HarvestAdminn.Models;
using HarvestAdminn.Services;
using Microsoft.AspNetCore.Mvc;

namespace HarvestAdminn.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result =
                await _authService.Login(model);

            if (result == null)
            {
                ViewBag.Error =
                    "Email atau Password salah";

                return View(model);
            }

            HttpContext.Session.SetString(
                "token",
                result.access_token);

            HttpContext.Session.SetString(
                "userId",
                result.data.id);

            HttpContext.Session.SetString(
                "userName",
                result.data.name);
            HttpContext.Session.SetString(
                "role",
                result.data.role);
            if (result.data.role == "user")
            {
                ViewBag.Error =
                    "User tidak diizinkan login ke website admin.";

                return View(model);
            }
            return RedirectToAction(
                "Index",
                "Dashboard");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction(
                "Login");
        }
    }
}