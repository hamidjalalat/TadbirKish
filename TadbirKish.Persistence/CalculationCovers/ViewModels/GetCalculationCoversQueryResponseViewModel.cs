using TadbirKish.Domain.Models;

namespace TadbirKish.Persistence.ViewModels
{
	public class GetCalculationCoversQueryResponseViewModel : object
	{
		public GetCalculationCoversQueryResponseViewModel() : base()
		{
		}

        public int CoverageCode { get; set; }

        public string Name { get; set; }

        public double Fund { get; set; }

        public double Calculated { get; set; }

        public Guid RequestRegistrationId { get; set; }

    }
}
