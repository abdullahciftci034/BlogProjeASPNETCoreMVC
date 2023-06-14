using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.ViewComponents.Blog
{
    public class BlogListLast3ByWriter : ViewComponent
    {
        public IBlogService blogService = new BlogManager(new EfBlogRepostory());
        public IViewComponentResult Invoke(int id)
        {
            var val = blogService.GetBlogListByWriter(id).TakeLast(3).Reverse().ToList();
            return View(val);
        }
    }
}
