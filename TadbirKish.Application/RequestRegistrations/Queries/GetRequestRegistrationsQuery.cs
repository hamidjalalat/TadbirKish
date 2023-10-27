using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.RequestRegistrations.Queries
{
	public class GetRequestRegistrationsQuery : object,
		Mediator.IRequest
		<IEnumerable<GetRequestRegistrationsQueryResponseViewModel>>
	{
		public GetRequestRegistrationsQuery() : base()
		{
		}

		public int? Count { get; set; }
	}
}
