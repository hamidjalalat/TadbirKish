using TadbirKish.Domain.Models;

namespace TadbirKish.Persistence.ViewModels
{
	public class GetCoveragesQueryResponseViewModel : object
	{
		public GetCoveragesQueryResponseViewModel() : base()
		{
		}

        public int Code { get; set; }

        public string Name { get; set; }

        public double Rate { get; set; }

    }
}
