using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HW_Week11.Contracts.Product;
using HW_Week11.Entities;
using Microsoft.Data.SqlClient;

namespace HW_Week11.Repositorys.Product
{
    public class DapperProductRepository : IDapperProductRepository
    {
        public void Create(Entities.Product product)
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                db.Execute(ProductQueries.Careate, new { product.Name, product.CategoryId, product.Price });
            }
        }

        public Entities.Product GetById(int id)
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                return db.QueryFirstOrDefault<Entities.Product>(ProductQueries.GetById, new {Id=id});
            }
        }
        public List<Entities.Product> GetAll()
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                return db.Query<Entities.Product, Entities.Category, Entities.Product>(ProductQueries.GetAll, (p, c) =>
                {
                    p.Category = c;
                    return p;

                }).ToList();
            }
            //using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            //{
            //    return db.Query<Entities.Product>(ProductQueries.GetAll).ToList();
            //}

        }

        public void Update(Entities.Product product)
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                db.Execute(ProductQueries.Update, new {Id = product.Id , product.Name, product.CategoryId, product.Price });
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(Configuration.Configuration.ConnectionString))
            {
                db.Execute(ProductQueries.Delete, new { Id = id });
            }
        }
    }
}
