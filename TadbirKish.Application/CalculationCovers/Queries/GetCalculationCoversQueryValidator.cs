using FluentValidation;

namespace TadbirKish.Application.CalculationCovers.Queries
{
	public class GetCalculationCoversQueryValidator :
		FluentValidation.AbstractValidator<GetCalculationCoversQuery>
	{
		public GetCalculationCoversQueryValidator() : base()
		{
            RuleFor(current => current.RequestRegistrationId)
            .NotEmpty()
            .WithMessage("الزامی می باشد");

        }
    }
}
