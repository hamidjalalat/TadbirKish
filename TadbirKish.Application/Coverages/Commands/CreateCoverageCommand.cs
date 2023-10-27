using TadbirKish.Domain.Models;

namespace TadbirKish.Application.Coverages.Commands
{

	public class CreateCoverageCommand : Mediator.IRequest<System.Guid>
	{
		public CreateCoverageCommand() : base()
		{
		}

        public int Code { get; set; }

        public string Name { get; set; }

        public decimal Rate { get; set; }

    }
}
