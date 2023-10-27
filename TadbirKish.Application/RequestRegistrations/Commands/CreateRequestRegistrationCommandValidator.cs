using FluentValidation;

namespace TadbirKish.Application.RequestRegistrations.Commands
{
	public class CreateRequestRegistrationCommandValidator :
		FluentValidation.AbstractValidator<Commands.CreateRequestRegistrationCommand>
	{
		public CreateRequestRegistrationCommandValidator() : base()
		{
			RuleFor(current => current.Subject)
				.NotEmpty()
				.WithMessage(errorMessage: "Requred");
		
		}
	}
}
