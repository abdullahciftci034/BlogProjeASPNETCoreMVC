using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommandService
	{
		void CommandAdd(Command command);
		void CategoryDelete(Command command);
		void CategoryUpdate(Command command);
		List<Command> GetAllCommands();
		List<Command> GetAllCommands(int id);
		Command GetCommandById(int Id);
	}
}
