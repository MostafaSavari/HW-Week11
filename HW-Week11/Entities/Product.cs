using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week11.Entities
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public Category? Category { get; set; }
        public Product()
        {

        }
        public Product(string name, int categoryId, int price)
        {
            Name = name;
            CategoryId = categoryId;
            Price = price;
        }
        public Product(int id,string name, int categoryId, int price)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Price = price;
        }



    }
}
