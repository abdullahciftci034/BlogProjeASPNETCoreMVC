using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents.Comment
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var values = new List<Writer> {
				new Writer{
					WriterName = "abdullah",
					WriterId = 1
				},
				new Writer{
					WriterName = "mehmet",
					WriterId = 2
				}
			};
			return View(values);
		}
	}
}
