using System;
using System.Web.UI;
using WebApplicationLogic;
using WebApplicationLogic.Presenters;
using WebApplicationLogic.Views;

namespace WebApplication
{
	public partial class Default : Page, IDefaultView
	{
		private DefaultPresenter _presenter;

		public bool LogoutLinkVisibility
		{
			set { LogoutLink.Visible = value; }
		}

		public string UserIdDisplay
		{
			set { LoggedInLiteral.Text = value; }
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			_presenter = ServiceLocator.DefaultPresenter(this);
			_presenter.HandlePageLoad();
		}
	}
}