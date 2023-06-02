using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommendService
	{
		void CommandAdd(Commend command);
		void CategoryDelete(Commend command);
		void CategoryUpdate(Commend command);
		List<Commend> GetAllCommands();
		List<Commend> GetAllCommands(int id);
		Commend GetCommandById(int Id);
	}
}
