
using Products.Models;

namespace Products.Contracts
{
    public interface IProductInfra
    {
        Product AddProduct(Product newProduct);

        IEnumerable<Product> GetProducts();
    }
}
