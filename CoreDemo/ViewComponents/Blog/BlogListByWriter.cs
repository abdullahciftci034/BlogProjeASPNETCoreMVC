using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents.Blog
{
    public class BlogListByWriter : ViewComponent
    {
        public IBlogService blogService = new BlogManager(new EfBlogRepostory());
        public IViewComponentResult Invoke(int id)
        {
            Console.WriteLine("yazdir");
            var val = blogService.GetBlogListByWriter(id);
            return View(val);
        }
    }
}
