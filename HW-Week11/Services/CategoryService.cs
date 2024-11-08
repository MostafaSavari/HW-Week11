using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_Week11.Contracts.Category;
using HW_Week11.Entities;
using HW_Week11.Repositorys.Product;

namespace HW_Week11.Services
{
    public class CategoryService :DapperProductRepository,ICategoryService
    {
        private IDapperCategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new Repositorys.Category.IDapperCategoryRepository();
        }
        public List<Category> GetAll()
        {
            List<Category> categories = _categoryRepository.GetAll();
            return categories;
        }
    }
}
