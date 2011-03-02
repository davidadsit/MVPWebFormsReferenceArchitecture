using Services.Services;
using WebApplicationLogic.Views;

namespace WebApplicationLogic.Presenters
{
	public class LoginPresenter
	{
		private readonly IUserState _userState;
		private readonly ILoginView _view;

		public LoginPresenter(ILoginView view, IUserState userState)
		{
			_view = view;
			_userState = userState;
		}

		public void HandlePageLoad()
		{
			string userId = _view.GetUserId();
			_userState.UserId = userId;
			_view.RedirectToDefault();
		}
	}
}