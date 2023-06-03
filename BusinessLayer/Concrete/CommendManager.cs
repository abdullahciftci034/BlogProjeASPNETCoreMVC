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
	public class CommendManager :GenericManager<Commend>,ICommendService
	{
		public ICommendDal commandDal;

		public CommendManager(ICommendDal commandDal) : base(commandDal)
		{
			this.commandDal = commandDal;
		}

		public List<Commend> GetAllCommands(int id)
		{
			return this.commandDal.GetAllList(x => x.BlogId == id);
		}

	}
}
