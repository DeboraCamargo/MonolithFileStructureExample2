namespace Products.Models
{
	public class Product
	{
		public string Name { get; set; } = string.Empty;

		public string Id { get; set; } = Guid.NewGuid().ToString();

		public float Price { get; set; }
	}
}
