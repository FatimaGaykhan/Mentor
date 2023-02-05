using System;
namespace Mentor3.Models
{
	public class TeacherCourse:BaseEntity
	{
		public int TeacherId { get; set; }
		public Teacher Teacher { get; set; }
		public int CourseId { get; set; }
		public Course Course { get; set; }
	}
}

