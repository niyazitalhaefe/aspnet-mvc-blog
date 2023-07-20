using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Travel(int id, int page)
        {
            return View();
        }
        public IActionResult Software(int id, int page)
        {
            return View();
        }
        public IActionResult Lifestyle(int id, int page)
        {
            return View();
        }
        public IActionResult Explore(int id, int page)
        {
            return View();
        }
    }
}
