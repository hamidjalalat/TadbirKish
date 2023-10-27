using TadbirKish.Domain.Models;
using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Persistence.CalculationCovers.Repositories
{
	public interface ICalculationCoverQueryRepository : TadbirKish.Persistence.Base.IQueryRepository<CalculationCover>
	{
		Task
			<IList<GetCalculationCoversQueryResponseViewModel>>
			GetSomeAsync(Guid requestRegistrationId);

     
    }
}
