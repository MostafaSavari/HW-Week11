using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week11.Contracts.Category
{
    public interface ICategoryService
    {
        List<Entities.Category> GetAll();
    }
}
