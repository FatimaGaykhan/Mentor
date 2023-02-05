using System;
namespace Mentor3.Models
{
	public class Product : BaseEntity
	{
		public string Title { get; set; }
		public string Price { get; set; }
		public bool IsAdvance { get; set; }
		public bool IsFeatured { get; set; }
	}
}

