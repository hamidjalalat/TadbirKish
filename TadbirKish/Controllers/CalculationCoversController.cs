
using Microsoft.AspNetCore.Mvc;
using TadbirKish.Application.CalculationCovers.Queries;
using TadbirKish.Application.Coverages.Queries;
using TadbirKish.Application.RequestRegistrations.Commands;
using TadbirKish.Persistence.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace LoggingMicroservice.Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Microsoft.AspNetCore.Mvc.Route
        (template: "[controller]")]
    public class CalculationCoversController : TadbirKish.Infrastructure.ControllerBase
    {
        public CalculationCoversController(MediatR.IMediator mediator) : base(mediator: mediator)
        {
        }


        #region Get (Get Coverages)
        [Microsoft.AspNetCore.Mvc.HttpGet()]
        public async Task<ActionResult<IEnumerable<GetCalculationCoversQueryResponseViewModel>>>
        GetAllCalculationCover(Guid requestRegistrationId)
        {

            var request =
               new GetCalculationCoversQuery()
               {
                    RequestRegistrationId = requestRegistrationId,
               };

            var result =
                await Mediator.Send(request);

            return Ok(value: result.Value);
        }
        #endregion Get (Get Coverages)
    }
}
