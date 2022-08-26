using e_shop.Application.Interfaces;
using e_shop.Application.Interfaces.DataStore;
using e_shop.Core.Models;

namespace e_shop.Application.Search
{
    public class SearchProduct : ISearchProduct
    {
        private readonly IProductRepository productRepository;
        public SearchProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(string? filter = null)
        {
            return productRepository.GetProducts(filter);
        }
    }
}