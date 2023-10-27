using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.RequestRegistrations.CommandHandlers
{
	public class GetBySubjectQueryHandler : 
		Mediator.IRequestHandler<Queries.GetBySubjectQuery, GetRequestRegistrationsQueryResponseViewModel>
	{
		public GetBySubjectQueryHandler
            (
			AutoMapper.IMapper mapper,
            TadbirKish.Persistence.IQueryUnitOfWork unitOfWork) : base()
		{
		
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected AutoMapper.IMapper Mapper { get; }

		protected TadbirKish.Persistence.IQueryUnitOfWork UnitOfWork { get; }

		

		public async Task<FluentResults.Result<GetRequestRegistrationsQueryResponseViewModel>>
			Handle(Queries.GetBySubjectQuery request, System.Threading.CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result
				<GetRequestRegistrationsQueryResponseViewModel>();

			try
			{

				var RequestRegistrations =await UnitOfWork.RequestRegistrations
                    .GetBySubjectAsync(Subject: request.Subject);
					;

				result.WithValue(value: RequestRegistrations);
			
			}
			catch (System.Exception ex)
			{
				result.WithError
					(errorMessage: ex.Message);
			}

			return result;
		}
	}
}
