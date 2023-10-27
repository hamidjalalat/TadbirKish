using System.Linq;
using TadbirKish.Domain.Models;
using TadbirKish.Persistence.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace TadbirKish.Persistence.Coverages.Repositories
{
	public class CoverageQueryRepository :
        TadbirKish.Persistence.Base.QueryRepository<Coverage>, ICoverageQueryRepository
    {
		public CoverageQueryRepository(QueryDatabaseContext databaseContext) : base(databaseContext)
		{
		}

		public async Task<IList<GetCoveragesQueryResponseViewModel>>
			GetSomeAsync()
		{

			var result =
				await
				DbSet
			
				.Select(current => new ViewModels.GetCoveragesQueryResponseViewModel()
				{
					   Code = current.Code,
					   Name = current.Name,
					   Rate = current.Rate,
				})
				.ToListAsync()
				;

			return result;
		}

        public async Task<GetCoveragesQueryResponseViewModel> GetByCodeAsync(int code)
        {
			var result =
			await
			DbSet.Where(C => C.Code == code).
			Select(current => new ViewModels.GetCoveragesQueryResponseViewModel()
			{
                Code = current.Code,
                Name = current.Name,
                Rate = current.Rate,

            })
            .FirstOrDefaultAsync();

            return result;
        }
    }
}
