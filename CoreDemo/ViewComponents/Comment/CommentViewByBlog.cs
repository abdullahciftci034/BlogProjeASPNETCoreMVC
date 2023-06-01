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
		ICommandService commandService = new CommandManager(new EfCommandRepostory());
		public IViewComponentResult Invoke(int id) {
			var val =commandService.GetAllCommands(id);

			return View(val);		
		}	
	}
}
