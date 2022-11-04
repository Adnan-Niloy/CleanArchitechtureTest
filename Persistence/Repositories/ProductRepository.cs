using Application.RepositorieInterfaces;
using Domain.Models;

namespace Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly AmmsOnlineTestContext _context;

        public ProductRepository(AmmsOnlineTestContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }
    }
}
