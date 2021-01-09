using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class FakeProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name = "Footbal", Price = 25},
            new Product {Name = "Surf Board", Price = 179},
            new Product {Name = "Running shoes", Price = 95}
        }.AsQueryable<Product>();
    }
}