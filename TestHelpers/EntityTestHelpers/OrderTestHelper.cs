using Entities;

namespace TestHelpers.EntityTestHelpers
{
	public static class OrderTestHelper
	{
		public static Order GetDefault(int id)
		{
			return new Order {Id = id};
		}
	}
}