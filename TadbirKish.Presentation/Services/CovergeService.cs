using System.Reflection;
using TadbirKish.Application.RequestRegistrations.Commands;
using TadbirKish.Persistence.ViewModels;
using TadbirKish.Presentation.Infrastructure;

namespace TadbirKish.Presentation.Services
{
    public class CovergeService:BaseService
    {
        public CovergeService(HttpClient client) : base(client)
        {

        }
        protected override string GetApiUrl()
        {
            return "Coverages";
        }

        public async Task<IList<GetCoveragesQueryResponseViewModel>>
        GetAsync()
        {
            var result = await GetAsync<IList<GetCoveragesQueryResponseViewModel>>();

            return result;
        }

        public async Task<Guid>
        PostAsync(CreateRequestRegistrationCommand viewModel)
        {
            var result =
                await
                PostAsync
                <CreateRequestRegistrationCommand, Guid>
                (viewModel);

            return result;
        }
    }
}
