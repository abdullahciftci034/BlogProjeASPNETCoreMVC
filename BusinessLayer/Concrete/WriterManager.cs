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
	public class WriterManager : IWriterService
	{
		IWriterDal writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			this.writerDal = writerDal;
		}

		public List<Writer> GetAllWriters()
		{
			return this.writerDal.GetAllList();
		}

		public Writer GetWritersById(int Id)
		{
			return this.writerDal.GetByID(Id);	
		}

		public void WriterAdd(Writer Writer)
		{
			this.writerDal.Insert(Writer);
		}

		public void WriterDelete(Writer Writer)
		{
			this.writerDal.Delete(Writer);
		}

		public void WriterUpdate(Writer Writer)
		{
			this.writerDal.Update(Writer);	
		}
	}
}
