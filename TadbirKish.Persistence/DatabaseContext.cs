using TadbirKish.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace TadbirKish.Persistence
{
	public class DatabaseContext :DbContext
	{
		public DatabaseContext
			(DbContextOptions<DatabaseContext> options) : base(options: options)
		{
			// TODO
			Database.EnsureCreated();
		}

		public DbSet<RequestRegistration> RequestRegistrations { get; set; }
		public DbSet<Coverage> Coverages { get; set; }
		public DbSet<CalculationCover> CalculationCovers { get; set; }

		protected override void OnModelCreating
			(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
