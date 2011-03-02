namespace WebApplicationLogic.Views
{
	public interface ILoginView
	{
		string GetUserId();
		void RedirectToDefault();
	}
}