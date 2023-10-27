using FluentValidation;

namespace TadbirKish.Application.CalculationCovers.Commands
{
	public class CreateCalculationCoverCommandValidator :
		FluentValidation.AbstractValidator<Commands.CreateCalculationCoverCommand>
	{
		public CreateCalculationCoverCommandValidator() : base()
		{
			RuleFor(current => current.Fund)
				.NotEmpty()
				.WithMessage(errorMessage: "Requred");
		
		}
	}
}
