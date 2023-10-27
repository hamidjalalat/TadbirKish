using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.Coverages.Queries
{
	public class GetCoveragesQuery : Mediator.IRequest
		<IEnumerable<GetCoveragesQueryResponseViewModel>>
	{
		public GetCoveragesQuery() : base()
		{
		}
	}
}
