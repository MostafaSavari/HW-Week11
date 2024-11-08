using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_Week11.Entities;

namespace HW_Week11.Contracts.Product
{
    public interface IDapperProductRepository
    {
        void Create(Entities.Product product);
        Entities.Product GetById(int id);
        List<Entities.Product> GetAll();
        void Update(Entities.Product product);
        void Delete(int id);
    }
}
