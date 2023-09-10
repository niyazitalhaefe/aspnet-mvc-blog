using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var slider = new List<SliderViewModel>
            {
                new SliderViewModel
                {
                    Date = DateTime.Now,
                    Name = "Our Favorite Weekend Getaways",
                    Title= "Software",
                    ImageUrl= "/images/slider/slider2.jpg"
                },
                new SliderViewModel
                {
                    Date = DateTime.Now,
                    Name = "Trip to California",
                    Title= "Travel",
                    ImageUrl= "/images/slider/slider1.jpg"
                },
                new SliderViewModel
                {
                    Date = DateTime.Now,
                    Name = "Tips for Taking a Long-term Trip",
                    Title= "LifeStyle",
                    ImageUrl= "/images/slider/slider3.jpg"
                },
                new SliderViewModel
                {
                    Date = DateTime.Now,
                    Name = "Tips for Taking a Long-term Trip",
                    Title= "LifeStyle",
                    ImageUrl= "/images/slider/slider1.jpg"
                },
                new SliderViewModel
                {
                    Date = DateTime.Now,
                    Name = "Tips for Taking a Long-term Trip",
                    Title= "LifeStyle",
                    ImageUrl= "/images/slider/slider2.jpg"
                },
            };

            return View(slider);
        }
    }
}

