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
	public class ContactManager : GenericManager<Contact>, IContactService
	{
		public IContactDal contactDal;
		public ContactManager(IContactDal contactDal) : base(contactDal)
		{
			this.contactDal = contactDal;
		}
	}

}
 