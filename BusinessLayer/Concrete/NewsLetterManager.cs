using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class NewsLetterManager :GenericManager<NewsLetter>,INewsLetterService
	{
		public INewsLetterDal newsLetterDal;

		public NewsLetterManager(INewsLetterDal newsLetterDal):base(newsLetterDal)
		{
			this.newsLetterDal = newsLetterDal;
		}
	}
}
