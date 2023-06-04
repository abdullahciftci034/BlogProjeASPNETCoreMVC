using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class RecentlyPost : ViewComponent
    {
        public IBlogService blogService = new BlogManager(new EfBlogRepostory());
        public IViewComponentResult Invoke()
        {
            var val = blogService.GetAllList();
            return View(val);
        }

    }
}
