using e_shop.Core.Models;

namespace e_shop.Application.Interfaces
{
    public interface IViewProduct
    {
        Product Execute(int id);
    }
}