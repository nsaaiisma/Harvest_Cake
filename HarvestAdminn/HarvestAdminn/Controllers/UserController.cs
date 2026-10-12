using Microsoft.AspNetCore.Mvc;

namespace HarvestAdminn.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}