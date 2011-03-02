using Services.Repositories;
using Services.Repositories.Oracle;
using Services.Services;
using WebApplicationLogic.ApplicationServices;
using WebApplicationLogic.ApplicationServices.Implementations;
using WebApplicationLogic.Presenters;
using WebApplicationLogic.Presenters.Handlers;
using WebApplicationLogic.Views;
using WebApplicationLogic.Views.Handlers;

namespace WebApplicationLogic
{
	public static class ServiceLocator
	{
		private static IEntityViewModelMapper EntityViewModelMapper
		{
			get { return new AutoMapperEntityViewModelMapper(); }
		}

		private static IProductRepository ProductRepository
		{
			get { return new OracleProductRepository(); }
		}

		private static IUserState UserState
		{
			get { return new UserSessionState(); }
		}

		public static DefaultPresenter DefaultPresenter(IDefaultView view)
		{
			return new DefaultPresenter(view, UserState);
		}

		public static LoginPresenter LoginPresenter(ILoginView view)
		{
			return new LoginPresenter(view, UserState);
		}

		public static ProductDetailsPresenter ProductDetailsPresenter(IProductDetailsView view)
		{
			return new ProductDetailsPresenter(view, ProductRepository, EntityViewModelMapper);
		}

		public static ProductNotesHandlerPresenter ProductNotesHandlerPresenter(IProductNotesHandler handler)
		{
			return new ProductNotesHandlerPresenter(handler, ProductRepository);
		}
	}
}