using TadbirKish.Application.CalculationCovers.Commands;
using TadbirKish.Domain.Models;

namespace TadbirKish.Application.RequestRegistrations.Commands
{

	public class CreateRequestRegistrationCommand : Mediator.IRequest<System.Guid>
	{
		public CreateRequestRegistrationCommand() : base()
		{
            CreateCalculationCoverCommands = new List<CreateCalculationCoverCommand>();
        }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage ="وارد کردن فیلد عنوان الزامی می باشد")]
        public string Subject { get; set; }

        public IList<CreateCalculationCoverCommand> CreateCalculationCoverCommands { get; set; }

    }
}
