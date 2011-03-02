using System.Linq;
using Entities;

namespace Services.Services.LocalServices
{
	public class TaxCalculationService : ITaxCalculator
	{
		private const decimal DefaultTaxRate = 1.06m;

		public decimal CalculateSalesTax(Order order)
		{
			return order.LineItems.Sum(x => x.LineTotal) * DefaultTaxRate;
		}
	}
}