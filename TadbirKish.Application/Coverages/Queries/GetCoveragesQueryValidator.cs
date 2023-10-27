using FluentValidation;

namespace TadbirKish.Application.Coverages.Queries
{
	public class GetCoveragesQueryValidator :
		FluentValidation.AbstractValidator<GetCoveragesQuery>
	{
		public GetCoveragesQueryValidator() : base()
		{
			
		}
	}
}
