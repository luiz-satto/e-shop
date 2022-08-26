using e_shop.Application.Interfaces;
using e_shop.Application.Interfaces.DataStore;
using e_shop.Core.Models;

namespace e_shop.Application.Search
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepository productRepository;
        public ViewProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product Execute(int id)
        {
            return productRepository.GetProduct(id);
        }
    }
}