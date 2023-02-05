using System;
namespace Mentor3.Models
{
	public class ProductAdvantage:BaseEntity
	{
		public bool IsAvailable { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
		public int AdvantageId { get; set; }
		public Advantage Advantage { get; set; }
	}
}

