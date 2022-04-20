using Microsoft.AspNetCore.Mvc;

namespace KDLibrary.Areas
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
