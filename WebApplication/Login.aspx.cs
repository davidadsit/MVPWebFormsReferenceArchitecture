using System;
using System.Web.UI;
using WebApplicationLogic;
using WebApplicationLogic.Presenters;
using WebApplicationLogic.Views;

namespace WebApplication
{
	public partial class Login : Page, ILoginView
	{
		private LoginPresenter _loginPresenter;

		public string GetUserId()
		{
			return Request.QueryString["UserId"];
		}

		public void RedirectToDefault()
		{
			Response.Redirect("Default.aspx");
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			_loginPresenter = ServiceLocator.LoginPresenter(this);
			_loginPresenter.HandlePageLoad();
		}
	}
}