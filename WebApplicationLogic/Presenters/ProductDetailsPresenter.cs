using Entities;
using Services.Repositories;
using WebApplicationLogic.ApplicationServices;
using WebApplicationLogic.ViewModels;
using WebApplicationLogic.Views;

namespace WebApplicationLogic.Presenters
{
	public class ProductDetailsPresenter
	{
		private readonly IEntityViewModelMapper _entityViewModelMapper;
		private readonly IProductRepository _productRepository;
		private readonly IProductDetailsView _view;

		public ProductDetailsPresenter(IProductDetailsView view, IProductRepository productRepository,
		                               IEntityViewModelMapper entityViewModelMapper)
		{
			_view = view;
			_productRepository = productRepository;
			_entityViewModelMapper = entityViewModelMapper;
		}

		public void HandlePageLoad()
		{
			int productId = _view.GetProductId();
			Product product = _productRepository.GetProductById(productId);
			ProductViewModel productViewModel = _entityViewModelMapper.GetProductViewModel(product);
			_view.DisplayProduct(productViewModel);
		}
	}
}