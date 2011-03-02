using System.Web;
using Services.Services;

namespace WebApplicationLogic.ApplicationServices.Implementations
{
	public class UserSessionState : IUserState
	{
		public string UserId
		{
			get { return GetValueFromSession<string>("UserId"); }
			set { SetValueInSession("UserId", value); }
		}

		private static T GetValueFromSession<T>(string key)
		{
			return (T) HttpContext.Current.Session[key];
		}

		private static void SetValueInSession<T>(string key, T value) where T : class
		{
			if (value == null)
			{
				HttpContext.Current.Session.Remove(key);
			}
			else
			{
				HttpContext.Current.Session[key] = value;
			}
		}
	}
}