using Microsoft.AspNetCore.Mvc;

namespace PalomoITELEC1C.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
