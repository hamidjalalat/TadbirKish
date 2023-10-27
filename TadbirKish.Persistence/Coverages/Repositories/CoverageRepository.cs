using TadbirKish.Domain.Models;
using Microsoft.EntityFrameworkCore;
using TadbirKish.Persistence.RequestRegistrations.Repositories;

namespace TadbirKish.Persistence.Coverages.Repositories
{
	public class CoverageRepository :
        TadbirKish.Persistence.Base.Repository<Coverage>, ICoverageRepository
    {
		protected internal CoverageRepository
            (DbContext databaseContext) : base(databaseContext: databaseContext)
		{
		}
	}
}
