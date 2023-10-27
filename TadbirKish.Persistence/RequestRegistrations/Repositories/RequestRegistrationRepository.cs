using TadbirKish.Domain.Models;
using Microsoft.EntityFrameworkCore;
using TadbirKish.Persistence.RequestRegistrations.Repositories;

namespace TadbirKish.Persistence.RequestRegistrations.Repositories
{
	public class RequestRegistrationRepository :
        TadbirKish.Persistence.Base.Repository<RequestRegistration>, IRequestRegistrationRepository
	{
		protected internal RequestRegistrationRepository
			(DbContext databaseContext) : base(databaseContext: databaseContext)
		{
		}
	}
}
