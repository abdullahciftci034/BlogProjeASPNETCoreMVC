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
	public class CommandManager : ICommandService
	{
		public ICommandDal commandDal;

		public CommandManager(ICommandDal commandDal)
		{
			this.commandDal = commandDal;
		}

		public void CategoryDelete(Command command)
		{
			throw new NotImplementedException();
		}

		public void CategoryUpdate(Command command)
		{
			throw new NotImplementedException();
		}

		public void CommandAdd(Command command)
		{
			throw new NotImplementedException();
		}

		public List<Command> GetAllCommands(int id)
		{
			return commandDal.GetAllList(x => x.BlogId == id);
		}

		public List<Command> GetAllCommands()
		{
			throw new NotImplementedException();
		}

		public Command GetCommandById(int Id)
		{
			throw new NotImplementedException();
		}

	}
}
