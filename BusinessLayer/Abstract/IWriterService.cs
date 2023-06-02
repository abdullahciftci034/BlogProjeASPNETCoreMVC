using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IWriterService
	{
		void WriterAdd(Writer Writer);
		void WriterDelete(Writer Writer);
		void WriterUpdate(Writer Writer);
		List<Writer> GetAllWriters();
		Writer GetWritersById(int Id);
	}
}
