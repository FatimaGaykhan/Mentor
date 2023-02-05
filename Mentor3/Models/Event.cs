using System;
namespace Mentor3.Models
{
	public class Event:BaseEntity
	{
		public string EventImage { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime StartDate { get; set; }

	}
}

