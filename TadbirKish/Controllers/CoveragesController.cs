
using Microsoft.AspNetCore.Mvc;
using TadbirKish.Application.Coverages.Queries;
using TadbirKish.Application.RequestRegistrations.Commands;
using TadbirKish.Persistence.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace LoggingMicroservice.Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Microsoft.AspNetCore.Mvc.Route
        (template: "[controller]")]
    public class CoveragesController : TadbirKish.Infrastructure.ControllerBase
    {
        public CoveragesController(MediatR.IMediator mediator) : base(mediator: mediator)
        {
        }

        #region Get (Get Coverages)
        [Microsoft.AspNetCore.Mvc.HttpGet()]
        public async Task <ActionResult<IEnumerable<GetCoveragesQueryResponseViewModel>>>
        GetAllCoverage()
        {

            var request =
               new GetCoveragesQuery();

            var result =
                await Mediator.Send(request);

            return Ok(value: result.Value);
        }
        #endregion Get (Get Coverages)


        #region Post (Create RequestRegistration)
        [Microsoft.AspNetCore.Mvc.HttpPost()]

        public async Task<ActionResult>
            CreateRequestRegistration(CreateRequestRegistrationCommand request)
        {

            var result =
                await Mediator.Send(request);

            return Ok(value: result.Value);
        }
        #endregion /Post (Create RequestRegistration)

  
    }
}
