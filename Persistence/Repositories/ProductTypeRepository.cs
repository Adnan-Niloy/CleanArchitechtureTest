using Application.RepositorieInterfaces;
using Domain.Models;

namespace Persistence.Repositories
{
    public class ProductTypeRepository : Repository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(AmmsOnlineTestContext context) : base(context)
        {
        }
    }
}
