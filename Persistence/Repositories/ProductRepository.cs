using Application.IRepositories;
using Domain.Models;

namespace Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AmmsOnlineTestContext context) : base(context)
        {
        }
    }
}
