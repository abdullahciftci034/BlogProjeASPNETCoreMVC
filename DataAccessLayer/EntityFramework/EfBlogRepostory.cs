using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repostory;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfBlogRepostory : GenericRepostory<Blog>, IBlogDal
	{
		public List<Blog> GetListWithCategory()
		{
			using (var context = new Context())
			{
				return context.blogs.Include(x=> x.Category).ToList();

			}

		}
	}
}
