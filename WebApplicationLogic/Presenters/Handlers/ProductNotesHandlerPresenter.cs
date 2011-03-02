using Services.Repositories;
using WebApplicationLogic.Views.Handlers;

namespace WebApplicationLogic.Presenters.Handlers
{
	public class ProductNotesHandlerPresenter
	{
		private readonly IProductNotesHandler _handler;
		private readonly IProductRepository _productRepository;

		public ProductNotesHandlerPresenter(IProductNotesHandler handler, IProductRepository productRepository)
		{
			_handler = handler;
			_productRepository = productRepository;
		}

		public void ProcessRequest()
		{
			switch (_handler.HttpMethod)
			{
				case "GET":
					_handler.Write(ProcessGet());
					break;
				case "POST":
					ProcessPost();
					break;
			}
		}

		private string ProcessGet()
		{
			int productId = _handler.ProductId;
			string notes = _productRepository.GetProductNotes(productId);
			return notes;
		}

		private void ProcessPost()
		{
			int productId = _handler.ProductId;
			string notes = _handler.Notes;
			_productRepository.SaveProductNotes(productId, notes);
		}
	}
}