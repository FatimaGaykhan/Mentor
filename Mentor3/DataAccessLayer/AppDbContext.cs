using System;
using Mentor3.Models;
using Microsoft.EntityFrameworkCore;

namespace Mentor3.DataAccessLayer
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext>options):base(options){}

		public DbSet<Setting> Settings { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Event> Events { get; set; }
		public DbSet<Offer> Offers { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<CourseTag> CourseTags { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Advantage> Advantages { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
        public DbSet<ProductAdvantage> ProductAdvantages { get; set; }
    }
}

