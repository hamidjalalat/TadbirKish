using TadbirKish.Domain.Models;
using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Persistence.Coverages.Repositories
{
	public interface ICoverageQueryRepository : TadbirKish.Persistence.Base.IQueryRepository<Coverage>
	{
		Task
			<IList<GetCoveragesQueryResponseViewModel>>
			GetSomeAsync();

		Task<GetCoveragesQueryResponseViewModel> GetByCodeAsync(int code);
     
    }
}
