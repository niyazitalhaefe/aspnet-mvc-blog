using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;

namespace MvcEticaret.ViewComponents
{
	public class ProductItemViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(string title, int starCount, double oldPrice, double price, string imageUrl, bool isSale)
		{
			var product = new ProductItemViewModel()
			{
				title = title,
				starCount = starCount,
				oldPrice = oldPrice,
				price = price,
				imageUrl = imageUrl,
				isSale = isSale,
			};

			return View(product);
		}
	}
}
