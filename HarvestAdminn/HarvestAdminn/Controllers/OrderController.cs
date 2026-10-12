using Microsoft.AspNetCore.Mvc;

namespace HarvestAdmin.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}