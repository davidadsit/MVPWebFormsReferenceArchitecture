using System;
using System.Web;
using WebApplicationLogic;
using WebApplicationLogic.Presenters.Handlers;
using WebApplicationLogic.Views.Handlers;

namespace WebApplication.Handlers
{
	public class ProductNotesHandler : IHttpHandler, IProductNotesHandler
	{
		private HttpContext _context;

		public string HttpMethod
		{
			get { return _context.Request.HttpMethod; }
		}

		public bool IsReusable
		{
			get { return false; }
		}

		public string Notes
		{
			get { return _context.Request.Form["data"]; }
		}

		public int ProductId
		{
			get { return Convert.ToInt32(_context.Request.QueryString["ProductId"]); }
		}

		public void ProcessRequest(HttpContext context)
		{
			_context = context;
			ProductNotesHandlerPresenter presenter = ServiceLocator.ProductNotesHandlerPresenter(this);
			presenter.ProcessRequest();
		}

		public void Write(string output)
		{
			_context.Response.Write(output);
		}
	}
}