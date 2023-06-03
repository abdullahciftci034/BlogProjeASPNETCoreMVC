using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : GenericManager<Blog>, IBlogService
	{
		IBlogDal blogDal;
		public BlogManager(IBlogDal blogDal):base(blogDal)
		{
			this.blogDal = blogDal;
		}
		public List<Blog> GetAllBlog(int id)
		{
			return this.dataLayer.GetAllList(x => x.BlogId == id);
		}
		public List<Blog> GetBlogListWithCategory()
		{
			return this.blogDal.GetListWithCategory();
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return this.dataLayer.GetAllList(x=>x.WriterId == id);
		}
	}
}
