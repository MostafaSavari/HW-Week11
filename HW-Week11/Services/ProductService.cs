using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_Week11.Contracts.Product;
using HW_Week11.Entities;
using HW_Week11.Repositorys.Product;

namespace HW_Week11.Services
{
    public class ProductService : DapperProductRepository, IProductService
    {
        private IDapperProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new DapperProductRepository();
        }
        public Result Add(Product product)
        {
            _productRepository.Create(product);
            return new Result(true, "Product added successfully");
        }

        public Product Get(int id)
        {
            List<Product> products = _productRepository.GetAll();
            Product p = new Product();
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    p = product;
                    return p ;
                }
            }
            return p;
        }

        public List<Product> GetAll()
        {
            List<Product> products = _productRepository.GetAll();
            return products;
        }

        public List<Product> SearchProduct(int id ,string categoryName)
        {
            List<Product> prodctSearch = new List<Product>();
            List<Product> products = _productRepository.GetAll();
            foreach (var p in products)
            {
                if (p.Id == id && p.Category.Name == categoryName)
                {
                    prodctSearch.Add(p);
                }
            }
            return prodctSearch;
        }

        public Result Update(Product product)
        {
            var products = GetAll();

            foreach (var p in products)
            {
                if (p.Id == product.Id)
                {
                    _productRepository.Update(product);
                    return new Result(true, "Product edited successfully");
                }
            }
            return new Result(false, "Editing failed -- NotFound");
        }

        public Result Remove(int id)
        {
            var products = GetAll();
            _productRepository.Delete(id);
            foreach (var p in products)
            {
                if (p.Id == id)
                {
                    _productRepository.Delete(id);
                    return new Result(true, "Product deleted successfully");
                }
            }
            return new Result(false, "deleted failed -- NotFound");

        }
    }
}
