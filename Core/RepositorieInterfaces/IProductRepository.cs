using Domain.Models;

namespace Application.RepositorieInterfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetProducts();
    }
}
