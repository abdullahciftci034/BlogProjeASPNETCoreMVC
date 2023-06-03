using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostory
{
	internal class NewsLetterRepostory : GenericRepostory<NewsLetter>, INewsLetterDal
	{
		public void Delete(NewsLetter value)
		{
			throw new NotImplementedException();
		}

		public List<NewsLetter> GetAllList(Expression<Func<NewsLetter, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Insert(NewsLetter value)
		{
			throw new NotImplementedException();
		}

		public void Update(NewsLetter value)
		{
			throw new NotImplementedException();
		}

		List<NewsLetter> IGenericDal<NewsLetter>.GetAllList()
		{
			throw new NotImplementedException();
		}

		NewsLetter IGenericDal<NewsLetter>.GetByID(int id)
		{
			throw new NotImplementedException();
		}
	}
}
