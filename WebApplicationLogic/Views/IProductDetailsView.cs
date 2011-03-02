using WebApplicationLogic.ViewModels;

namespace WebApplicationLogic.Views
{
	public interface IProductDetailsView
	{
		void DisplayProduct(ProductViewModel productViewModel);
		int GetProductId();
	}
}