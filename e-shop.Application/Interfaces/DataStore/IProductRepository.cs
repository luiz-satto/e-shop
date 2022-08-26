using System.Collections.Generic;
using e_shop.Core.Models;

namespace e_shop.Application.Interfaces.DataStore;
public interface IProductRepository
{
    IEnumerable<Product> GetProducts(string? filter = null);
    Product GetProduct(int id);
}