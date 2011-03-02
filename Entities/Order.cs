using System.Collections.Generic;
using System.Linq;

namespace Entities
{
	public class Order
	{
		private readonly List<OrderLineItem> _orderLineItems;

		public Order()
		{
			_orderLineItems = new List<OrderLineItem>();
		}

		public Address BillingAddress { get; set; }
		public int Id { get; set; }

		public IEnumerable<OrderLineItem> LineItems
		{
			get { return _orderLineItems; }
		}

		public Address ShippingAddress { get; set; }

		public void AddItem(Product product, int quantity)
		{
			OrderLineItem orderLineItem = _orderLineItems.FirstOrDefault(x => x.ProductId == product.Id);
			if (orderLineItem == null)
			{
				_orderLineItems.Add(new OrderLineItem(product, quantity));
			}
			else
			{
				orderLineItem.AddQuantity(quantity);
			}
		}
	}
}