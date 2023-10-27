using System.Linq;
using TadbirKish.Domain.Models;
using TadbirKish.Persistence.ViewModels;
using Microsoft.EntityFrameworkCore;
using TadbirKish.Persistence.Coverages.Repositories;
using TadbirKish.Persistence.Base;

namespace TadbirKish.Persistence.CalculationCovers.Repositories
{
	public class CalculationCoverQueryRepository :
        TadbirKish.Persistence.Base.QueryRepository<CalculationCover>, ICalculationCoverQueryRepository
    {
		public CalculationCoverQueryRepository(QueryDatabaseContext databaseContext) : base(databaseContext)
		{

        }

        public async Task
			<IList<GetCalculationCoversQueryResponseViewModel>>
			GetSomeAsync(Guid requestRegistrationId)
		{

               var result =await DbSet
			.Where(C=>C.RequestRegistrationId == requestRegistrationId)
				.Select(current => new ViewModels.GetCalculationCoversQueryResponseViewModel()
				{
					   Fund = current.Fund,
                       Calculated = current.Calculated,
                       CoverageCode = current.CoverageCode,
					   RequestRegistrationId = requestRegistrationId,

                })
				.ToListAsync()
				;

			return result;
		}
      
    }
}
