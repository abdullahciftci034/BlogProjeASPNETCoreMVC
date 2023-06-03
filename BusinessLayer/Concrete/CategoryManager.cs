using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager :GenericManager<Category>, ICategoryService
    {
        ICategoryDal iCategoryDal; 

        public CategoryManager(ICategoryDal iCategoryDal):base(iCategoryDal)
        {
            this.iCategoryDal = iCategoryDal;
        }

    }
}
