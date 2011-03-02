using Services.Services;
using WebApplicationLogic.Views;

namespace WebApplicationLogic.Presenters
{
	public class DefaultPresenter
	{
		private readonly IUserState _userState;
		private readonly IDefaultView _view;

		public DefaultPresenter(IDefaultView view, IUserState userState)
		{
			_view = view;
			_userState = userState;
		}

		public void HandlePageLoad()
		{
			string userId = _userState.UserId;
			_view.UserIdDisplay = string.IsNullOrEmpty(userId) ? string.Empty : string.Format("Logged in as: {0}", userId);
			_view.LogoutLinkVisibility = !string.IsNullOrEmpty(userId);
		}
	}
}