using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepostory());
        public IActionResult Index()
        {
            var values = blogManager.GetAllBlogs();
            return View(values);
        }
    }
}
