using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{
		public ICategoryService categoryService = new CategoryManager(new EfCategoryRepostory());
		public IViewComponentResult Invoke()
		{
			var val=categoryService.GetAllCategories();
			return View(val);
		}
	}
}
