using NUnit.Framework;
using TestHelpers.ViewModelTestHelpers;
using WebApplicationLogic.ViewModels;

namespace UnitTests.ViewModels
{
	[TestFixture]
	public class ProductViewModelTests
	{
		[Test]
		public void PriceIsFormattedAsCurrency()
		{
			ProductViewModel productViewModel = ProductViewModelTestHelper.GetDefault(0);
			productViewModel.Price = 123.45m;
			Assert.AreEqual("$123.45", productViewModel.FormattedPrice);
		}
	}
}