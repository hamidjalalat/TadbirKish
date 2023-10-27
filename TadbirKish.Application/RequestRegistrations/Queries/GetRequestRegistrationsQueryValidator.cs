using FluentValidation;

namespace TadbirKish.Application.RequestRegistrations.Queries
{
	public class GetRequestRegistrationsQueryValidator :
		FluentValidation.AbstractValidator<GetRequestRegistrationsQuery>
	{
		public GetRequestRegistrationsQueryValidator() : base()
		{
			RuleFor(current => current.Count)
				.NotEmpty()
				.WithMessage(errorMessage: "Count is required!")

				;
		}
	}
}
