using Entities;
using WebApplicationLogic.ViewModels;

namespace WebApplicationLogic.ApplicationServices
{
	public interface IEntityViewModelMapper
	{
		ProductViewModel GetProductViewModel(Product product);
	}
}