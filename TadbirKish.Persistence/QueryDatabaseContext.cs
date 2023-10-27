using TadbirKish.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace TadbirKish.Persistence
{
	public class QueryDatabaseContext : DbContext
	{
		public QueryDatabaseContext
			(Microsoft.EntityFrameworkCore.DbContextOptions<QueryDatabaseContext> options) : base(options: options)
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
