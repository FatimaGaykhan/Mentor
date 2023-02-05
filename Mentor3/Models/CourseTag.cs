using System;
namespace Mentor3.Models
{
	public class CourseTag:BaseEntity
	{
		public int CourseId { get; set; }
		public Course Course { get; set; }
		public int TagId { get; set; }
		public Tag Tag { get; set; }
	}
}

