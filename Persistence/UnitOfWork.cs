using Application;
using Application.IRepositories;
using Persistence.Repositories;

namespace Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AmmsOnlineTestContext _context;

        public IProductRepository Products { get; private set; }
        public IProductTypeRepository ProductTypes { get; private set; }
        public IProductCategoryRepository ProductCategories { get; private set; }

        public UnitOfWork(AmmsOnlineTestContext context)
        {
            _context = context;
            Products = new ProductRepository(context);
            ProductTypes = new ProductTypeRepository(context);
            ProductCategories = new ProductCategoryRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
