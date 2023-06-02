using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Blog blog);
		void BlogDelete(Blog blog);
		void BlogUpdate(Blog blog);
		Blog GetBlogById(int Id);
		List<Blog> GetAllBlog();
		List<Blog> GetAllBlog(int i);
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetBlogListByWriter(int id);
	}
}
