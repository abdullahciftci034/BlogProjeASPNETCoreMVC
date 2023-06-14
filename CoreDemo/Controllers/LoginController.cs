using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	
	public class LoginController : Controller
	{
		[AllowAnonymous]
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> Index(Writer writer)
		{
			Console.WriteLine(writer.WriterMail);	
			Context context = new Context();
			var dataValue = context.writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
			if(dataValue != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,writer.WriterMail)
				};
				var useridentyfy = new ClaimsIdentity(claims, "a");
				ClaimsPrincipal principal = new ClaimsPrincipal(useridentyfy);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index","Writer");	
			}
			
			return View();
		}
		
	}
}
