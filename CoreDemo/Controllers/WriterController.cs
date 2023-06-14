using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{

	
	public class WriterController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}

		[AllowAnonymous]
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			return View();
		}
		public IActionResult WriterProfile()
		{
			return View();
		}
		public IActionResult WriterMail() 
		{ 
			return View();
		}

		[AllowAnonymous]
		public IActionResult WriterDashbord()
		{
			return View();
		}
	}
}
