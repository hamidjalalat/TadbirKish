using System.Reflection;
using TadbirKish.Application.RequestRegistrations.Commands;
using TadbirKish.Persistence.ViewModels;
using TadbirKish.Presentation.Infrastructure;

namespace TadbirKish.Presentation.Services
{
    public class CalculationCoverService : BaseService
    {
        public CalculationCoverService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "CalculationCovers";
        }

        public async Task<IList<GetCalculationCoversQueryResponseViewModel>>
        GetAsync(string requestRegistrationId)
        {
            var result = await GetAsyncByrequestRegistrationId <IList<GetCalculationCoversQueryResponseViewModel>>(requestRegistrationId);

            return result;
        }

    
    }
}
