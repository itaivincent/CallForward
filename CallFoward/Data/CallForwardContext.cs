using System;
using CallFoward.Models;
using Microsoft.EntityFrameworkCore;

namespace CallFoward.Data
{
	public class CallForwardContext : DbContext
	{
		public CallForwardContext(DbContextOptions options) : base( options )
		{

		}

		public virtual DbSet<Unit> Units { get; set; }
	}
}

