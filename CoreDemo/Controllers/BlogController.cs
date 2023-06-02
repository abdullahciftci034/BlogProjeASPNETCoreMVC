using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
		IBlogService blogManager = new BlogManager(new EfBlogRepostory());
		
		public IActionResult Index()
        {
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogDetails(int id)
        {
            ViewBag.id = id;
            var values = this.blogManager.GetAllBlog(id);
            foreach (var blog in values) {
                ViewBag.WriterId = blog.WriterId;
            }
			return View(values);
        }

	}
}
