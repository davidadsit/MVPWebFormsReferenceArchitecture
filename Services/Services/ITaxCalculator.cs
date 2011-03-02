using Entities;

namespace Services.Services
{
	public interface ITaxCalculator
	{
		decimal CalculateSalesTax(Order order);
	}
}