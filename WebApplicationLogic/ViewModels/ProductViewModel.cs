namespace WebApplicationLogic.ViewModels
{
	public class ProductViewModel
	{
		public string Description { get; set; }

		public string FormattedPrice
		{
			get { return Price.ToString("c"); }
		}

		public int Id { get; set; }
		public decimal Price { get; set; }
	}
}