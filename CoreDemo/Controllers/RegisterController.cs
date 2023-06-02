using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		IWriterService writerService = new WriterManager(new EfWriterRepostory());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			WriterValidator validationRules = new WriterValidator();
			ValidationResult validation=validationRules.Validate(writer);
			if(validation.IsValid) {
				writer.WriterStatus = true;
				writer.WriterAbout = "Klass adam";
				writerService.WriterUpdate(writer);
				return RedirectToAction("Index","Blog");
			}
			foreach(var item in validation.Errors)
			{
				ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
			}
			return View();
		}
	}
}
