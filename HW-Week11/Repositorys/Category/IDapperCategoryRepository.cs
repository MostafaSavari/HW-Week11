using HW_Week11.Configuration;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HW_Week11.Repositorys.Category
{
    public class IDapperCategoryRepository :Contracts.Category.IDapperCategoryRepository
    {
        public Entities.Category GetById(int id)
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                return db.QueryFirstOrDefault<Entities.Category>(CategoryQueries.GetById, new { Id = id });
            }
        }

        public List<Entities.Category> GetAll()
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                return db.Query<Entities.Category>(CategoryQueries.GetAll).ToList();
            }
        }
    }
}
