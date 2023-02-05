using System;
namespace Mentor3.Models
{
	public class Tag:BaseEntity
	{
		public string Title { get; set; }
		public List<CourseTag> CourseTags { get; set; }
	}
}

