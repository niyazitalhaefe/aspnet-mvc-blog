﻿using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.ViewComponents
{
	public class BlogDetailsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
