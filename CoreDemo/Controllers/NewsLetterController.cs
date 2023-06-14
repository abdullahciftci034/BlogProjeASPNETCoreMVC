
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class NewsLetterController : Controller
	{
		public INewsLetterService newsLetterService = new NewsLetterManager(new EfNewsLetterRepostory());
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
		public ActionResult SubscribeMail(NewsLetter newsLetter)
		{
			newsLetter.MailStatus = true;
			newsLetterService.Insert(newsLetter);
			return RedirectToAction("index","/blog");
			
		}
		public ActionResult SubscribeMail1(NewsLetter newsLetter)
		{
			newsLetter.MailStatus = true;
			newsLetterService.Insert(newsLetter);
			return RedirectToAction("index", "/blog");

		}

	}
	
}
