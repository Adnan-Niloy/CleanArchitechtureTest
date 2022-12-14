using Application.RepositorieInterfaces;
using Domain.Models;

namespace Persistence.Repositories
{
    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(AmmsOnlineTestContext context) : base(context)
        {
        }
    }
}
