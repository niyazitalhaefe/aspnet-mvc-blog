using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
	public class BlogSearchViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
