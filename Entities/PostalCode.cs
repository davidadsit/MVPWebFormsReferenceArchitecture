namespace Entities
{
	public class PostalCode
	{
		private string _plusFour;
		private string _zip;

		public string PlusFour
		{
			get { return _plusFour; }
			set { _plusFour = (value ?? string.Empty).PadLeft(4).Substring(0, 4); }
		}

		public string Zip
		{
			get { return _zip; }
			set { _zip = (value ?? string.Empty).PadLeft(5).Substring(0, 5); }
		}
	}
}