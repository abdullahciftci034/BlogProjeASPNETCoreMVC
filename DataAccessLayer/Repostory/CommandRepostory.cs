using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostory
{
    public class CommandRepostory : GenericRepostory<Command>, ICommandDal
    {
        public void Delete(Command value)
        {
            throw new NotImplementedException();
        }

        public List<Command> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Command GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Command value)
        {
            throw new NotImplementedException();
        }

        public void Update(Command value)
        {
            throw new NotImplementedException();
        }
    }
}
