using TadbirKish.Domain.Models;
using Microsoft.EntityFrameworkCore;
using TadbirKish.Persistence.RequestRegistrations.Repositories;

namespace TadbirKish.Persistence.CalculationCovers.Repositories
{
	public class CalculationCoverRepository :
        TadbirKish.Persistence.Base.Repository<CalculationCover>, ICalculationCoverRepository
    {
		protected internal CalculationCoverRepository
            (DbContext databaseContext) : base(databaseContext: databaseContext)
		{
		}
	}
}
