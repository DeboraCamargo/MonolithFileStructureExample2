using Products.Contracts;
using Products.Models;

namespace Products.Infra
{
	public class ProductInfra : IProductInfra
	{
		public Product AddProduct(Product newProduct)
		{
			return newProduct;
		}

		public IEnumerable<Product> GetProducts()
		{
			return new List<Product>()
			{
				new()
				{
					Name = "Toddy",
					Price = 50f,
				}
			};
		}
	}
}
