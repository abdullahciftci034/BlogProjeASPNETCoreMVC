using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostory
{
    public class WriterRepostory : GenericRepostory<Writer>, IWriterDal
    {
        public void Delete(Writer value)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Writer GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer value)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer value)
        {
            throw new NotImplementedException();
        }
    }
}
