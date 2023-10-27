using System.Linq;
using TadbirKish.Domain.Models;
using TadbirKish.Persistence.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace TadbirKish.Persistence.RequestRegistrations.Repositories
{
	public class RequestRegistrationQueryRepository :
        TadbirKish.Persistence.Base.QueryRepository<RequestRegistration>, IRequestRegistrationQueryRepository
	{
		public RequestRegistrationQueryRepository(QueryDatabaseContext databaseContext) : base(databaseContext)
		{
		}

		public async Task<IList<GetRequestRegistrationsQueryResponseViewModel>>
			GetSomeAsync(int count)
		{

			var result =await DbSet
			
				.Select(current => new ViewModels.GetRequestRegistrationsQueryResponseViewModel()
				{
					 Subject = current.Subject,
				})
				.ToListAsync()
				;

			return result;
		}


        public async Task<GetRequestRegistrationsQueryResponseViewModel> GetBySubjectAsync(String subject)
        {
		
			var result =await DbSet.Where(C => C.Subject == subject).
			Select(current => new ViewModels.GetRequestRegistrationsQueryResponseViewModel()
			{
                Subject = current.Subject,
            })
            .FirstOrDefaultAsync();

            return result;
        }
    }
}
