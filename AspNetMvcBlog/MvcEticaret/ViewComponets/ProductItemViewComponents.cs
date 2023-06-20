using Microsoft.AspNetCore.Mvc;

namespace MvcEticaret.ViewComponets
{
        public class ProductItemViewComponents : ViewComponent
        {
            public IViewComponentResult Invoke()
            {
                return View();// burası değişecek hata vermemesi için return view yaptım.
            }
        }
    
}
