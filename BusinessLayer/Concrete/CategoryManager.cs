using BusinessLayer.Abstract;
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
        EfCategoryRepostory efCategoryRepostory;
        public CategoryManager()
        {
            this.efCategoryRepostory = new EfCategoryRepostory();
        }
        public void CategoryAdd(Category category)
        {
           this.efCategoryRepostory.Insert(category);    
        }

        public void CategoryDelete(Category category)
        {
            this.efCategoryRepostory.Delete(category);  
        }

        public void CategoryUpdate(Category category)
        {
           this.efCategoryRepostory.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return this.efCategoryRepostory.GetAllList();
        }

        public Category GetCategoriesById(int Id)
        {
           return this.efCategoryRepostory.GetByID(Id);
        }
    }
}
