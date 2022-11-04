using Application.RepositorieInterfaces;

namespace Application;

public interface IUnitOfWork : IDisposable
{
    IProductRepository Products { get; }
    IProductTypeRepository ProductTypes { get; }
    IProductCategoryRepository ProductCategories { get; }

    void Complete();
}