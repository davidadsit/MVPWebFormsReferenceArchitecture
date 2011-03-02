using Entities;
using Moq;
using NUnit.Framework;
using Services.Repositories;
using TestHelpers.EntityTestHelpers;
using TestHelpers.ViewModelTestHelpers;
using WebApplicationLogic.ApplicationServices;
using WebApplicationLogic.Presenters;
using WebApplicationLogic.ViewModels;
using WebApplicationLogic.Views;

namespace UnitTests.Presenters
{
	[TestFixture]
	public class ProductDetailsPresenterTests
	{
		[SetUp]
		public void SetUp()
		{
			_viewMock = new Mock<IProductDetailsView>();
			_productRepositoryMock = new Mock<IProductRepository>();
			_entityViewModelMapperMock = new Mock<IEntityViewModelMapper>();
			_presenter = new ProductDetailsPresenter(_viewMock.Object, _productRepositoryMock.Object,
			                                         _entityViewModelMapperMock.Object);
		}

		[TearDown]
		public void TearDown()
		{
			_viewMock.Verify();
			_productRepositoryMock.Verify();
			_entityViewModelMapperMock.Verify();
		}

		private Mock<IProductDetailsView> _viewMock;
		private ProductDetailsPresenter _presenter;
		private Mock<IProductRepository> _productRepositoryMock;
		private Mock<IEntityViewModelMapper> _entityViewModelMapperMock;

		[Test]
		public void HandlePageLoad_DisplaysProductViewModelFromEntityViewModelMapperOnView()
		{
			const int productId = 1;
			_viewMock
				.Setup(x => x.GetProductId())
				.Returns(productId);
			Product product = ProductTestHelper.GetDefault(productId);
			_productRepositoryMock
				.Setup(x => x.GetProductById(productId))
				.Returns(product);
			ProductViewModel productViewModel = ProductViewModelTestHelper.GetDefault(productId);
			_entityViewModelMapperMock
				.Setup(x => x.GetProductViewModel(product))
				.Returns(productViewModel);
			_viewMock
				.Setup(x => x.DisplayProduct(productViewModel))
				.Verifiable();

			_presenter.HandlePageLoad();
		}

		[Test]
		public void HandlePageLoad_GetsProductFromProductRepositoryUsingProductIdFromView()
		{
			const int productId = 1;
			_viewMock
				.Setup(x => x.GetProductId())
				.Returns(productId);
			_productRepositoryMock
				.Setup(x => x.GetProductById(productId))
				.Verifiable();

			_presenter.HandlePageLoad();
		}

		[Test]
		public void HandlePageLoad_GetsProductIdFromView()
		{
			_viewMock
				.Setup(x => x.GetProductId())
				.Returns(1)
				.Verifiable();

			_presenter.HandlePageLoad();
		}

		[Test]
		public void HandlePageLoad_GetsProductViewModelFromEntityViewModelMapper()
		{
			const int productId = 1;
			_viewMock
				.Setup(x => x.GetProductId())
				.Returns(productId);
			Product product = ProductTestHelper.GetDefault(productId);
			_productRepositoryMock
				.Setup(x => x.GetProductById(productId))
				.Returns(product);
			ProductViewModel productViewModel = ProductViewModelTestHelper.GetDefault(productId);
			_entityViewModelMapperMock
				.Setup(x => x.GetProductViewModel(product))
				.Returns(productViewModel)
				.Verifiable();

			_presenter.HandlePageLoad();
		}
	}
}