using System.Collections.Generic;

namespace WebApplication
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
    }
}
