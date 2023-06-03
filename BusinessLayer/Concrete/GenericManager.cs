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
	public class GenericManager<T> : IGenericService<T>
	{
		 public IGenericDal<T> dataLayer;

		public GenericManager(IGenericDal<T> dataLayer)
		{
			this.dataLayer = dataLayer;
		}

		public void Insert(T t)
		{
			this.dataLayer.Insert(t);
		}
		public void Delete(T t)
		{
			this.dataLayer.Delete(t);
		}

		public void Update(T t)
		{
			this.dataLayer.Update(t);	
		}
		public T GetById(int Id)
		{
			return this.dataLayer.GetByID(Id);
		}
		public List<T> GetAllList()
		{
			return this.dataLayer.GetAllList();
		}
	}
}
