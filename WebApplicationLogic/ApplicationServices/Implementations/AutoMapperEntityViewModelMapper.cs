using AutoMapper;
using Entities;
using WebApplicationLogic.ViewModels;

namespace WebApplicationLogic.ApplicationServices.Implementations
{
	public class AutoMapperEntityViewModelMapper : IEntityViewModelMapper
	{
		public AutoMapperEntityViewModelMapper()
		{
			Mapper.CreateMap<Product, ProductViewModel>();
		}

		public ProductViewModel GetProductViewModel(Product product)
		{
			return Mapper.Map<Product, ProductViewModel>(product);
		}
	}
}