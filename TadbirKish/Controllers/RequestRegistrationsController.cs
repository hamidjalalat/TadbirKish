
using Microsoft.AspNetCore.Mvc;
using TadbirKish.Application.Coverages.Queries;
using TadbirKish.Persistence.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace LoggingMicroservice.Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Microsoft.AspNetCore.Mvc.Route
        (template: "[controller]")]
    public class RequestRegistrationsController : TadbirKish.Infrastructure.ControllerBase
    {
        public RequestRegistrationsController(MediatR.IMediator mediator) : base(mediator: mediator)
        {
        }
   
    }
}
