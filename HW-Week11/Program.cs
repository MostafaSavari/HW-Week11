

using System.ComponentModel;
using HW_Week11.Entities;
using HW_Week11.Services;

ProductService productService = new ProductService();
CategoryService categoryService = new CategoryService();
var categories = categoryService.GetAll();
var productList = productService.GetAll();


//Console.ReadKey();

ProductMenu();


void ProductMenu()
{
    Console.Clear();
    int productID = 0;
    string productName = string.Empty;
    string categoryName = string.Empty;
    int categoryID = 0;
    int price = 0;
    try
    {
        Console.WriteLine("1.Add Product");
        Console.WriteLine("2.Show All Products");
        Console.WriteLine("3.Search Product By ID And Category Name");
        Console.WriteLine("4.Edit Product");
        Console.WriteLine("5.Remove Product");
        Console.WriteLine("6.Exit");
        var input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.Clear();
                foreach (var category in categories)
                {
                    Console.WriteLine($"CategoryID = {category.Id} - CategoryName: {category.Name}");
                }
                Console.Write("\nEnter Name : ");
                productName = Console.ReadLine();
                Console.Write("\nEnter CategoryID: ");
                categoryID = int.Parse(Console.ReadLine());
                Console.Write("\nPrice Price: ");
                price = int.Parse(Console.ReadLine());
                //add Product
                Product product = new Product(productName, categoryID, price);
                var result = productService.Add(product);
                Console.WriteLine(result.Message);
                Console.ReadKey();
                ProductMenu();

                break;
            case 2:
                Console.Clear();
                foreach (var p in productService.GetAll())
                {
                    Console.WriteLine($"ProdcutID : {p.Id} -- ProductName: {p.Name} -- CategoryName: {p.Category.Name} -- ProdctPrice: {p.Price}");
                }
                Console.ReadKey();
                ProductMenu();
                break;
            case 3:
                Console.Clear();
                Console.Write("\nPlease Enter Product ID : ");
                productID = int.Parse(Console.ReadLine());
                Console.Write("\nPlase Enter Category Name: ");
                  categoryName = Console.ReadLine();
                var search = productService.SearchProduct(productID, categoryName);
                if (search.Count > 0)
                {
                    foreach (var s in search)
                    {
                        Console.WriteLine($"ProdcutID : {s.Id} -- ProductName: {s.Name} -- CategoryName: {s.Category.Name} -- ProdctPrice: {s.Price}");
                    }
                }
                else
                {
                    Console.WriteLine("No record found");
                }
                //Search Product By ID And Category Name
                Console.ReadKey();
                ProductMenu();
                break;
            case 4:
                Console.Clear();
                //Edit Product
                Console.WriteLine("------Categories--------");
                foreach (var category in categories)
                {
                    Console.WriteLine($"CategoryID = {category.Id} - CategoryName: {category.Name}");
                }
                Console.WriteLine("------Products--------");
                foreach (var p in productService.GetAll())
                {
                    Console.WriteLine($"ProdcutID : {p.Id} -- ProductName: {p.Name} -- CategoryName: {p.Category.Name} -- ProdctPrice: {p.Price}");
                }
                Console.Write("\nPlease Enter Product ID : ");
                productID = int.Parse(Console.ReadLine());
                Console.Write("\nPlease Enter Product Name : ");
                productName = Console.ReadLine();
                Console.Write("\nPlease Enter CategoryID : ");
                categoryID = int.Parse(Console.ReadLine());
                Console.Write("\nPlease Enter Price : ");
                price = int.Parse(Console.ReadLine());

                Product pro = new Product(productID, productName, categoryID, price);
                var resultUpdate =productService.Update(pro);
                Console.WriteLine(resultUpdate.Message);
                Console.ReadKey();
                ProductMenu();
                break;
            case 5:
                Console.Clear();
                //Remove Product
                foreach (var p in productService.GetAll())
                {
                    Console.WriteLine($"ProdcutID : {p.Id} -- ProductName: {p.Name} -- CategoryName: {p.Category.Name} -- ProdctPrice: {p.Price}");
                }
                Console.Write("Please Enter Product ID : ");
                productID = int.Parse(Console.ReadLine());
                var reulstDelte = productService.Remove(productID);
                Console.WriteLine(reulstDelte.Message);
                Console.ReadKey();
                ProductMenu();
                break;
            case 6:
                //Exit
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("input Incorrect!");
                break;
        }
    }
    catch (Exception e)
    {
        ProductMenu();
    }
    
}