﻿using System;
namespace Mentor3.Models
{
	public class BaseEntity
	{
		
		public int Id { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public DateTime? DeletedAt { get; set; }

    }
}
