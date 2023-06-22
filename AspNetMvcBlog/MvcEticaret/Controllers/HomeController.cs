using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var products = new List<ProductItemViewModel>();

            products.Add(new ProductItemViewModel() { title = "FO", isSale = true, oldPrice = 90.75, starCount = 2, imageUrl = "/images/kahve1.jpg", price = 81.99 });
            products.Add(new ProductItemViewModel() { title = "Nescafe", isSale = false, oldPrice = 82.5, starCount = 1, imageUrl = "/images/kahve2.jpg", price = 75.98 });
            products.Add(new ProductItemViewModel() { title = "Starbucks", isSale = false, oldPrice = 74.99, starCount = 3, imageUrl = "/images/kahve3.jpg", price = 48.99 });
            products.Add(new ProductItemViewModel() { title = "Tchibo", isSale = true, oldPrice = 105.8, starCount = 3, imageUrl = "/images/kahve4.jpg", price = 55 });
            products.Add(new ProductItemViewModel() { title = "Monin", isSale = false, oldPrice = 80, starCount = 3, imageUrl = "/images/kahve5.jpg", price = 65.99 });
            products.Add(new ProductItemViewModel() { title = "Jacobs", isSale = true, oldPrice = 65, starCount = 3, imageUrl = "/images/kahve6.jpg", price = 50 });
            products.Add(new ProductItemViewModel() { title = "Shazel", isSale = false, oldPrice = 59.4, starCount = 3, imageUrl = "/images/kahve7.jpg", price = 39.99 });
            products.Add(new ProductItemViewModel() { title = "Oze", isSale = true, oldPrice = 40, starCount = 5, imageUrl = "/images/kahve8.jpg", price = 50 });

            return View(products);

        }
    }
}