using System;
namespace Mentor3.Models
{
	public class Teacher:BaseEntity
	{
		public string Name { get; set; }
		public string Surname {get;set;}
		public string Description { get; set; }
		public string TeacherImage { get; set; }
		public string Instagramlink { get; set; }
		public string LinkedinLink { get; set; }
		public string FacebookLnk { get; set; }
		public string TwitterLink { get; set; }
        public List<TeacherCourse> TeacherCourses { get; set; }

    }
}

