using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.RequestRegistrations.Queries
{
	public class GetBySubjectQuery : object,
		Mediator.IRequest
		<GetRequestRegistrationsQueryResponseViewModel>
	{
		public GetBySubjectQuery() : base()
		{
		}

		public string Subject { get; set; }
	}
}
