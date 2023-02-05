using System;
namespace Mentor3.Models
{
	public class Course:BaseEntity
	{
		public string CourseImage { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int AvailableSeats { get; set; }
		public DateTime StartDate { get; set; }
		public List<CourseTag> CourseTags { get; set; }
		public List<TeacherCourse> TeacherCourses { get; set; }
        public DateTime EndDate { get; set; }


    }
}

