using TadbirKish.Domain.Models;

namespace TadbirKish.Application.CalculationCovers.Commands
{

	public class CreateCalculationCoverCommand : Mediator.IRequest<System.Guid>
	{
		public CreateCalculationCoverCommand() : base()
		{
		}
        public bool Selected { get; set; }

        public int Code { get; set; }

        public string Name { get; set; }

        public double Rate { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "وارد کردن فیلد سرمایه الزامی می باشد")]
        public double Fund { get; set; }

        public double Calculated { get; set; }

        public Guid RequestRegistrationId { get; set; }


    }
}
