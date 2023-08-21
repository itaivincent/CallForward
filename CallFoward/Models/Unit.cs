using System;
using System.ComponentModel.DataAnnotations;

namespace CallFoward.Models
{
	public class Unit
	{	
		public int Id { get; set; }

		[Required]
		[StringLength(25)]
		public String Name { get; set; }

		[StringLength(75)]
		public String Description { get; set; }
	}
}

