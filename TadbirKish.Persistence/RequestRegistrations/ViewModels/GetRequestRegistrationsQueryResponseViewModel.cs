using TadbirKish.Domain.Models;

namespace TadbirKish.Persistence.ViewModels
{
	public class GetRequestRegistrationsQueryResponseViewModel : object
	{
		public GetRequestRegistrationsQueryResponseViewModel() : base()
		{
		}


        public string Subject { get; set; }
        public IList<CalculationCover> CalculationCovers { get; set; }

    }
}
