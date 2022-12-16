using Products.Models;

namespace Products.Contracts
{
	public interface IProductBusiness
	{
		Product AddProduct(Product newProduct);

		IEnumerable<Product> GetProducts();
	}
}
