using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repostory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class CommendController : Controller
	{
		public ICommendService commandService=new CommendManager(new EfCommendRepostory());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult CommandListByBLog(int id) {


			var values = commandService.GetAllCommands(id);
			return PartialView(values);
		}

		
	}
}
