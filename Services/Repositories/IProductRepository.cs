using Entities;

namespace Services.Repositories
{
	public interface IProductRepository
	{
		Product GetProductById(int productId);
		string GetProductNotes(int productId);
		void Save(Product product);
		void SaveProductNotes(int productId, string notes);
	}
}