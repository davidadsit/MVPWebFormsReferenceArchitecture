namespace Entities
{
	public class OrderLineItem
	{
		private readonly Product _product;
		private int _quantity;

		public OrderLineItem(Product product, int quantity)
		{
			_product = product;
			_quantity = quantity;
		}

		public decimal LineTotal
		{
			get { return _product.Price * _quantity; }
		}

		public int ProductId
		{
			get { return _product.Id; }
		}

		public int Quantity
		{
			get { return _quantity; }
		}

		public void AddQuantity(int additionalQuantity)
		{
			_quantity += additionalQuantity;
		}
	}
}