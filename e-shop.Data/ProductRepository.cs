using e_shop.Core.Models;
using e_shop.Application.Interfaces.DataStore;

namespace e_shop.Data;
public class ProductRepository : IProductRepository
{
    private List<Product> Products { get; set; }
    public ProductRepository()
    {
        Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Brand = "Apple",
                Name = "Apple iPhone 11, 128GB, Red - Fully Unlocked (Renewed)",
                Price = 398.80,
                ImageLink = "https://m.media-amazon.com/images/I/51wbAAz5O6L._AC_SL1112_.jpg",
                Description = @"This phone is unlocked and compatible with any carrier of choice on GSM and CDMA networks (e.g. AT&T, T-Mobile, Sprint, Verizon, US Cellular, Cricket, Metro, Tracfone, Mint Mobile, etc.).
                Tested for battery health and guaranteed to have a minimum battery capacity of 80%.
                Successfully passed a full diagnostic test which ensures like-new functionality and removal of any prior-user personal information.
                The device does not come with headphones or a SIM card. It does include a generic (Mfi certified) charger and charging cable.
                Inspected and guaranteed to have minimal cosmetic damage, which is not noticeable when the device is held at arm's length."
            },
            new Product
            {
                Id = 2,
                Brand = "Apple",
                Name = "Apple iPhone 12 Pro, 256GB, Pacific Blue - Unlocked (Renewed Premium)",
                Price = 849.00,
                ImageLink = "https://m.media-amazon.com/images/I/712yl2wTDbL._AC_SL1500_.jpg",
                Description = @"Unlocked and compatible with any carrier of choice on GSM and CDMA networks (e.g. AT&T, T-Mobile, Sprint, Verizon, US Cellular, Cricket, Metro, Tracfone, Mint Mobile, etc.).
                Tested for battery health and guaranteed to come with a battery that exceeds 90% of original capacity.
                Inspected and guaranteed to have minimal cosmetic damage, which is not noticeable when the device is held at arm's length. Successfully passed a full diagnostic test which ensures like-new functionality and removal of any prior-user personal information.
                Includes a brand new, generic charging cable that is certified Mfi (Made for iPhone) and a brand new, generic wall plug that is UL certified for performance and safety. Also includes a SIM tray removal tool but does not come with headphones or a SIM card.
                Backed by a one-year satisfaction guarantee."
            },
            new Product
            {
                Id = 3,
                Brand = "Apple",
                Name = "Apple iPhone SE (2nd Generation), US Version, 64GB, White - Unlocked (Renewed)",
                Price = 179.00,
                ImageLink = "https://m.media-amazon.com/images/I/812JKRJ1nZL._AC_SL1500_.jpg",
                Description = @"This phone is unlocked and compatible with any carrier of choice on GSM and CDMA networks (e.g. AT&T, T-Mobile, Sprint, Verizon, US Cellular, Cricket, Metro, Tracfone, Mint Mobile, etc.).
                Tested for battery health and guaranteed to have a minimum battery capacity of 80%.
                Successfully passed a full diagnostic test which ensures like-new functionality and removal of any prior-user personal information.
                The device does not come with headphones or a SIM card. It does include a generic (Mfi certified) charger and charging cable.
                Inspected and guaranteed to have minimal cosmetic damage, which is not noticeable when the device is held at arm's length."
            },
            new Product
            {
                Id = 4,
                Brand = "Apple",
                Name = "Apple iPhone 7 Plus, US Version, 32GB, Silver - Unlocked (Renewed)",
                Price = 151.95,
                ImageLink = "https://m.media-amazon.com/images/I/61eD3jLV5JL._AC_SL1328_.jpg",
                Description = @"This pre-owned product has been professionally inspected, tested and cleaned by Amazon qualified vendors. It is not certified by Apple.
                This product is in 'Excellent condition'. The screen and body show no signs of cosmetic damage visible from 12 inches away.
                This product will have a battery that exceeds 80% capacity relative to new.
                Accessories may not be original, but will be compatible and fully functional. Product may come in generic box.
                Product will come with a SIM removal tool, a charger and a charging cable. Headphone and SIM card are not included.
                This product is eligible for a replacement or refund within 90-day of receipt if it does not work as expected.
                Refurbished phones are not guaranteed to be waterproof."
            },
            new Product
            {
                Id = 5,
                Brand = "Apple",
                Name = "Apple iPhone X, 64GB, Silver - For GSM (Renewed) ",
                Price = 234.90,
                ImageLink = "https://m.media-amazon.com/images/I/71rIdtluUqL._AC_SL1500_.jpg",
                Description = @"This phone is compatible with carriers on the GSM network only (e.g. AT&T, T-Mobile, Metro).
                Tested for battery health and guaranteed to come with a battery that exceeds 90% of original capacity.
                Inspected and guaranteed to have minimal cosmetic damage, which is not noticeable when the device is held at arm's length. Successfully passed a full diagnostic test which ensures like-new functionality and removal of any prior-user personal information.
                Includes a brand new, generic charging cable that is certified Mfi (Made for iPhone) and a brand new, generic wall plug that is UL certified for performance and safety. Also includes a SIM tray removal tool but does not come with headphones or a SIM card.
                Backed by the same one-year satisfaction guarantee as brand new Apple products."
            }
        };
    }

    public Product GetProduct(int id)
    {
        return this.Products.First(x => x.Id == id);
    }

    public IEnumerable<Product> GetProducts(string? filter = null)
    {
        if (string.IsNullOrWhiteSpace(filter))
            return Products;

        return Products.Where(x =>
        {
            if (string.IsNullOrWhiteSpace(x.Name)) return false;
            return x.Name.ToLower().Contains(filter.ToLower());
        });
    }
}