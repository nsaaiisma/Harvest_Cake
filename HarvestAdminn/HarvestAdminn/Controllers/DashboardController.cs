using Microsoft.AspNetCore.Mvc;

namespace HarvestAdminn.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}