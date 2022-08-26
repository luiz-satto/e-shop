using System.Collections.Generic;
using e_shop.Core.Models;

namespace e_shop.Application.Interfaces
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string? filter = null);
    }
}