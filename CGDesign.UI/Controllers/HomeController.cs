using Microsoft.AspNetCore.Mvc;

namespace CGDesign.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}