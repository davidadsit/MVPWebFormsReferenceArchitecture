using System;
using Entities;

namespace Services.Repositories.Oracle
{
	public class OracleProductRepository : IProductRepository
	{
		public Product GetProductById(int productId)
		{
			return new Product
			       	{
			       		Id = productId,
			       		Description = string.Format("Product {0}", productId),
			       		Price = 6 * productId
			       	};
		}

		public string GetProductNotes(int productId)
		{
			return string.Format("Really long product notes: {0}", productId);
		}

		public void Save(Product product)
		{
			throw new NotImplementedException();
		}

		public void SaveProductNotes(int productId, string notes)
		{
			throw new NotImplementedException();
		}
	}
}