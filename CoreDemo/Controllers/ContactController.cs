using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		IContactService contactService =new ContactManager(new EfContactRepostory());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contact.ContactStatus = true;
			contact.ContactDate =DateTime.Now;
			contactService.Insert(contact);	
			return View();
		}
	}
}
