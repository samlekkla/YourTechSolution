using Microsoft.AspNetCore.Mvc;

namespace YourTechSolution.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
