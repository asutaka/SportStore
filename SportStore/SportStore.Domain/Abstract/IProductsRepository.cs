using SportStore.Domain.Entities;
using System.Collections.Generic;

namespace SportStore.Domain.Abstract
{
    public interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
