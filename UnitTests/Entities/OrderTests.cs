using System.Linq;
using Entities;
using NUnit.Framework;
using TestHelpers.EntityTestHelpers;

namespace UnitTests.Entities
{
	[TestFixture]
	public class OrderTests
	{
		[Test]
		public void AddingProductMultipleTimesDoesNotIncreasesLineItemCount()
		{
			Order order = OrderTestHelper.GetDefault(0);
			order.AddItem(ProductTestHelper.GetDefault(1), 1);
			order.AddItem(ProductTestHelper.GetDefault(1), 2);
			order.AddItem(ProductTestHelper.GetDefault(1), 3);
			Assert.AreEqual(1, order.LineItems.Count());
		}

		[Test]
		public void AddingProductMultipleTimesIncreasesQuantity()
		{
			Order order = OrderTestHelper.GetDefault(0);
			order.AddItem(ProductTestHelper.GetDefault(1), 1);
			order.AddItem(ProductTestHelper.GetDefault(1), 2);
			order.AddItem(ProductTestHelper.GetDefault(1), 3);
			Assert.IsTrue(order.LineItems.Any(x => x.ProductId == 1 && x.Quantity == 6));
		}

		[Test]
		public void LineItemsInInitializedDuringConstruction()
		{
			Order order = new Order();
			Assert.IsNotNull(order.LineItems);
		}

		[Test]
		public void NewlyConstructedOrderHasNoLineItems()
		{
			Order order = new Order();
			Assert.AreEqual(0, order.LineItems.Count());
		}

		[Test]
		public void ProductAddedToOrderIsFoundInOrderLineItems()
		{
			Order order = OrderTestHelper.GetDefault(0);
			Product product = ProductTestHelper.GetDefault(0);
			const int quantity = 5;
			order.AddItem(product, quantity);
			Assert.IsTrue(order.LineItems.Any(x => x.ProductId == product.Id && x.Quantity == quantity));
		}
	}
}