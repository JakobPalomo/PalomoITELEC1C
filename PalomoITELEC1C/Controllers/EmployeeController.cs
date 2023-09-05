using Microsoft.AspNetCore.Mvc;

namespace PalomoITELEC1C.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
