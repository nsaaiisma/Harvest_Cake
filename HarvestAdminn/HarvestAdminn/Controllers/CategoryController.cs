using Microsoft.AspNetCore.Mvc;

namespace HarvestAdminn.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}