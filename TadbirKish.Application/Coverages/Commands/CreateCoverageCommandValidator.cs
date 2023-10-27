using FluentValidation;

namespace TadbirKish.Application.Coverages.Commands
{
	public class CreateCoverageCommandValidator :
		FluentValidation.AbstractValidator<Commands.CreateCoverageCommand>
	{
		public CreateCoverageCommandValidator() : base()
		{
			RuleFor(current => current.Code)
				.NotEmpty()
				.WithMessage(errorMessage: "Requred");
		
		}
	}
}
