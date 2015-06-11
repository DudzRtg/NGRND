using Engrande.Contract;
using Engrande.Entities;
using Engrande.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engrande.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork _uow;

        public CategoryService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IQueryable<Category> GetEntities()
        {
            return _uow.CategoryRepo.RetrieveEntities();
        }

        public List<KeyValuePair<string,string>> GetCategoryIdName()
        {
            List<KeyValuePair<string,string>> list = new List<KeyValuePair<string, string>>();

            foreach(var item in GetCategoriesList(null, null))
            {
                list.Add(new KeyValuePair<string,string>(item.Id.ToString(), item.Name));
            }

            return list;
        }

        public IQueryable<CategoryView> GetCategoriesList(Nullable<int> page, Nullable<int> count)
        {
            int pageParam = page ?? 1;
            int countParam = count ?? int.MaxValue;

            return _uow.CategoryRepo.GetCategoriesList<CategoryView>(pageParam, countParam);
        }


        
    }
}
