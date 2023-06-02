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
    public class CommendRepostory : GenericRepostory<Commend>, ICommendDal
    {
        public void Delete(Commend value)
        {
            throw new NotImplementedException();
        }

        public List<Commend> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Commend GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Commend value)
        {
            throw new NotImplementedException();
        }

        public void Update(Commend value)
        {
            throw new NotImplementedException();
        }
    }
}
