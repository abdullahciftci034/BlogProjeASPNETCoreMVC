using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents.Comment
{
	public class CommentViewByBlog : ViewComponent
	{
		ICommendService commendService = new CommendManager(new EfCommendRepostory());
		public IViewComponentResult Invoke(int id) {
			var val =commendService.GetAllCommands(id);

			return View(val);		
		}	
	}
}
