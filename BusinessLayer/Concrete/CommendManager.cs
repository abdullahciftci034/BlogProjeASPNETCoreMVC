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
	public class CommendManager : ICommendService
	{
		public ICommendDal commandDal;

		public CommendManager(ICommendDal commandDal)
		{
			this.commandDal = commandDal;
		}

		public void CategoryDelete(Commend command)
		{
			throw new NotImplementedException();
		}

		public void CategoryUpdate(Commend command)
		{
			throw new NotImplementedException();
		}

		public void CommandAdd(Commend command)
		{
			throw new NotImplementedException();
		}

		public List<Commend> GetAllCommands(int id)
		{
			return commandDal.GetAllList(x => x.BlogId == id);
		}

		public List<Commend> GetAllCommands()
		{
			throw new NotImplementedException();
		}

		public Commend GetCommandById(int Id)
		{
			throw new NotImplementedException();
		}

	}
}
