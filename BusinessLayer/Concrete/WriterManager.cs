using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class WriterManager :GenericManager<Writer>, IWriterService
	{
		IWriterDal writerDal;

		public WriterManager(IWriterDal writerDal):base(writerDal)
		{
			this.writerDal = writerDal;
		}
	}
}
