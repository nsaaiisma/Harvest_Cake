using Microsoft.AspNetCore.Mvc;

namespace HarvestAdminn.Controllers
{
    public class BannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}