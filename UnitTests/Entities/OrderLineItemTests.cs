using Entities;
using NUnit.Framework;
using TestHelpers.EntityTestHelpers;

namespace UnitTests.Entities
{
	[TestFixture]
	public class OrderLineItemTests
	{
		private const int Quantity = 5;

		[Test]
		public void LineTotalIsQuantityTimesProductPrice()
		{
			Product product = ProductTestHelper.GetDefault(0);
			product.Price = 12.34m;
			OrderLineItem orderLineItem = new OrderLineItem(product, Quantity);
			Assert.AreEqual(product.Price * Quantity, orderLineItem.LineTotal);
		}

		[Test]
		public void ProductIdAccessorReturnsIdOfProductPassedIntoConstructor()
		{
			Product product = ProductTestHelper.GetDefault(3);
			OrderLineItem orderLineItem = new OrderLineItem(product, Quantity);
			Assert.AreEqual(3, orderLineItem.ProductId);
		}

		[Test]
		public void QuantityCanBeAdded()
		{
			Product product = ProductTestHelper.GetDefault(0);
			OrderLineItem orderLineItem = new OrderLineItem(product, Quantity);
			orderLineItem.AddQuantity(3);
			Assert.AreEqual(8, orderLineItem.Quantity);
		}

		[Test]
		public void QuantityIsInitializedFromConstructor()
		{
			OrderLineItem orderLineItem = new OrderLineItem(ProductTestHelper.GetDefault(0), Quantity);
			Assert.AreEqual(Quantity, orderLineItem.Quantity);
		}
	}
}