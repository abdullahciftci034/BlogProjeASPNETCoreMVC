using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		private IBlogDal iBlogDal;

		public BlogManager(IBlogDal iBlogDal)
		{
			this.iBlogDal = iBlogDal;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}
		public Blog GetBlogById(int Id)
		{
			throw new NotImplementedException();
		}
		public List<Blog> GetAllBlog()
		{
			return this.iBlogDal.GetAllList();
		}
		public List<Blog> GetAllBlog(int id)
		{
			return iBlogDal.GetAllList(x => x.BlogId == id);
		}
		public List<Blog> GetBlogListWithCategory()
		{
			return iBlogDal.GetListWithCategory();
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			Console.WriteLine("managera girdi");
			return iBlogDal.GetAllList(x=>x.WriterId == id);
		}
	}
}
