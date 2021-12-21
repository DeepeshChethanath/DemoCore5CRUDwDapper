using DemoCore5CRUDwDapper.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore5CRUDwDapper.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Category>> GetAllCategory();
    }
}
