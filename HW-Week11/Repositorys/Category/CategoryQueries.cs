using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week11.Repositorys.Category
{
    public static class CategoryQueries
    {

        public static string GetById = "SELECT * FROM dbo.Categories WHERE Id = @Id;";
        public static string GetAll = "SELECT * FROM dbo.Categories";
    }
}
