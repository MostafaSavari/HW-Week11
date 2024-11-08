using HW_Week11.Entities;

namespace HW_Week11.Contracts.Product
{
    public interface IProductService
    {
        public Result Add(Entities.Product product);
        public Entities.Product Get(int id);
        public List<Entities.Product> GetAll();
        public Result Update(Entities.Product product);
        public Result Remove(int id);
    }
}
