using WebApplicationLogic.ViewModels;

namespace TestHelpers.ViewModelTestHelpers
{
	public static class ProductViewModelTestHelper
	{
		public static ProductViewModel GetDefault(int id)
		{
			return new ProductViewModel {Id = id};
		}
	}
}