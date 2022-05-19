using Microsoft.AspNetCore.Mvc;

namespace netProject
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Sono la Home!!");
        }
    }
}