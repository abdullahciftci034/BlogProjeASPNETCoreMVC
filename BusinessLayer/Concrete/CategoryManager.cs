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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal iCategoryDal;
        public CategoryManager(ICategoryDal iCategoryDal)
        {
            this.iCategoryDal = iCategoryDal;
        }
        public void CategoryAdd(Category category)
        {
           this.iCategoryDal.Insert(category);    
        }

        public void CategoryDelete(Category category)
        {
            this.iCategoryDal.Delete(category);  
        }

        public void CategoryUpdate(Category category)
        {
           this.iCategoryDal.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return this.iCategoryDal.GetAllList();
        }

        public Category GetCategoriesById(int Id)
        {
           return this.iCategoryDal.GetByID(Id);
        }
    }
}
