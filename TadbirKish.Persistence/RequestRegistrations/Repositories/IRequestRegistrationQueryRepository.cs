using TadbirKish.Domain.Models;
using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Persistence.RequestRegistrations.Repositories
{
	public interface IRequestRegistrationQueryRepository : TadbirKish.Persistence.Base.IQueryRepository<RequestRegistration>
	{
		Task
			<IList<GetRequestRegistrationsQueryResponseViewModel>>
			GetSomeAsync(int count);

		Task<GetRequestRegistrationsQueryResponseViewModel> GetBySubjectAsync(String Subject);
     
    }
}
