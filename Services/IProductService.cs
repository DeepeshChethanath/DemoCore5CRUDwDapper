using DemoCore5CRUDwDapper.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore5CRUDwDapper.Services
{
    public interface IProductService
    {
        public Task<List<Product>> GetAllProducts();
        public Task<List<Category>> GetAllCategory();
        public Task<Product> GetProductById(int id);
        public Task<int> CreateProductAsync(Product product);
        public Task<int> UpdateProductAsync(Product product);
        public Task<int> DeleteProductAsync(Product product);
    }
}
