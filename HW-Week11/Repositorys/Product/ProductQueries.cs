using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week11.Repositorys.Product
{
    public static class ProductQueries
    {
        public static string Careate =
            "INSERT INTO Products (Name ,CategoryId,Price ) VALUES (@Name, @CategoryId,@Price )";

        public static string GetById = "SELECT * FROM dbo.Products WHERE Id = @Id;";
        public static string GetAll = "SELECT P.*,C.* FROM dbo.Products P INNER JOIN dbo.Categories C ON C.Id = P.CategoryId";

        public static string Update =
            "UPDATE dbo.Products SET [Name] = @Name ,CategoryId = @CategoryId ,Price = @Price WHERE Id = @Id";

        public static string Delete = "DELETE dbo.Products WHERE Id = @Id";


    }
}
