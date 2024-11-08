using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_Week11.Entities;

namespace HW_Week11.Contracts.Category
{
    public interface IDapperCategoryRepository
    {
        Entities.Category GetById(int id);
        List<Entities.Category> GetAll();
    }
}
