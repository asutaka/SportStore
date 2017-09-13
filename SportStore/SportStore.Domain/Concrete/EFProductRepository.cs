using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;
using System.Collections.Generic;
namespace SportStore.Domain.Concrete
{
    public class EFProductRepository: IProductsRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
