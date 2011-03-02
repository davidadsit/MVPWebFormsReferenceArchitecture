using Entities;

namespace TestHelpers.EntityTestHelpers
{
	public static class ProductTestHelper
	{
		public static Product GetDefault(int id)
		{
			return new Product {Id = id};
		}
	}
}