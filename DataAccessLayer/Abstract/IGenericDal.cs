using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> 
    {
        void Insert(T value);
        void Delete(T value);
        void Update(T value);
        List<T> GetAllList();
        T GetByID(int id);
        List<T> GetAllList(Expression<Func<T,bool>> filter);
    }
}
