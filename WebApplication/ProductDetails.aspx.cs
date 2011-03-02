using System;
using System.Web.UI;
using WebApplicationLogic;
using WebApplicationLogic.Presenters;
using WebApplicationLogic.ViewModels;
using WebApplicationLogic.Views;

namespace WebApplication
{
	public partial class ProductDetails : Page, IProductDetailsView
	{
		private ProductDetailsPresenter _presenter;

		public void DisplayProduct(ProductViewModel productViewModel)
		{
			IdLiteral.Text = productViewModel.Id.ToString();
			DescriptionLiteral.Text = productViewModel.Description;
			PriceLiteral.Text = productViewModel.FormattedPrice;
		}

		public int GetProductId()
		{
			string productIdString = Request.QueryString["ProductId"];
			int productId;
			int.TryParse(productIdString, out productId);
			return productId;
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			_presenter = ServiceLocator.ProductDetailsPresenter(this);
			_presenter.HandlePageLoad();
		}
	}
}