namespace WebApplicationLogic.Views.Handlers
{
	public interface IProductNotesHandler
	{
		string HttpMethod { get; }
		string Notes { get; }
		int ProductId { get; }
		void Write(string output);
	}
}