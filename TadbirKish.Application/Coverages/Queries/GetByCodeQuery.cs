using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.Coverages.Queries
{
	public class GetByCodeQuery : Mediator.IRequest
		<GetCoveragesQueryResponseViewModel>
	{
		public GetByCodeQuery() : base()
		{
		}

		public int Code { get; set; }
	}
}
