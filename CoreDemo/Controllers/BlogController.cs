using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
    {
		IBlogService blogManager = new BlogManager(new EfBlogRepostory());
		
		public IActionResult Index()
        {
            var values = blogManager.GetBlogListWithCategory().TakeLast(9).Reverse().ToList();
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
