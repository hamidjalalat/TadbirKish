using Microsoft.AspNetCore.Mvc;

namespace TadbirKish.Infrastructure
{
	public abstract class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
	{
		protected ControllerBase(MediatR.IMediator mediator) : base()
		{
			Mediator = mediator;
		}

		protected MediatR.IMediator Mediator { get; }

		protected IActionResult FluentResult<T>(FluentResults.Result<T> result)
		{
			if (result.IsSuccess)
			{
				return Ok(value: result.Value);
			}
			else
			{
				return BadRequest(error: result.ToResult());
			}
		}
	}
}
