using System;
using System.ComponentModel.DataAnnotations;

namespace Mentor3.Models
{
	public class Setting:BaseEntity
	{
		[StringLength(50),Required]
		public string AboutUsTitle { get; set; }
		[StringLength(1500)]
		public string AboutUsDescription { get; set; }
		[StringLength(50)]
		public string Location { get; set; }
		[StringLength(50),Required]
		public string Email { get; set; }
        [StringLength(50), Required]
        public string PhoneNumber { get; set; }
		public string Logo { get; set; }
		public string AboutUsImage { get; set; }

    }
}

