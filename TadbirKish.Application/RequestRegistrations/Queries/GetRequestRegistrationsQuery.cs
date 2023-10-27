using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.RequestRegistrations.Queries
{
	public class GetRequestRegistrationsQuery : object,
		Mediator.IRequest
		<System.Collections.Generic.IEnumerable<GetRequestRegistrationsQueryResponseViewModel>>
	{
		public GetRequestRegistrationsQuery() : base()
		{
		}

		public int? Count { get; set; }
	}
}
