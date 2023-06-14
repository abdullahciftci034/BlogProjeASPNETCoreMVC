using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class CategoryController : Controller
    {
        CategoryManager categoryManager=new CategoryManager(new EfCategoryRepostory());  
        public IActionResult Index()
        {
            var values = categoryManager.GetAllList();
            return View(values);  
        }
      
    }
}
