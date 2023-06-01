using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostory
{
    public class ContactRepostory : GenericRepostory<Contact>, IContactDal
    {
        public void Delete(Contact value)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Contact GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Contact value)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact value)
        {
            throw new NotImplementedException();
        }
    }
}
