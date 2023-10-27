using TadbirKish.Domain.Models;
using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.CalculationCovers.Queries
{
	public class GetCalculationCoversQuery : Mediator.IRequest
		<IEnumerable<GetCalculationCoversQueryResponseViewModel>>
	{
		public GetCalculationCoversQuery() : base()
		{

		}
        public Guid RequestRegistrationId { get; set; }
    }
}
