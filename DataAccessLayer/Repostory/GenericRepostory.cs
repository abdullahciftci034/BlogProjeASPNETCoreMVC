using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostory
{
    public class GenericRepostory<T> : IGenericDal<T> where T : class
    {
        Context context=new Context();
        public void Delete(T value)
        {
            context.Add(value);
            context.SaveChanges();  
        }

        public List<T> GetAllList()
        {

            return context.Set<T>().ToList();
              
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Insert(T value)
        {
            context.Add(value);
            context.SaveChanges();  
        }

        public void Update(T value)
        {
            context.Update(value);  
            context.SaveChanges();
        }
    }
}
