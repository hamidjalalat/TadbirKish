using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.Coverages.CommandHandlers
{
	public class GetByCodeQueryHandler : 
		Mediator.IRequestHandler<Queries.GetByCodeQuery, GetCoveragesQueryResponseViewModel>
	{
		public GetByCodeQueryHandler
            (
			AutoMapper.IMapper mapper,
            TadbirKish.Persistence.IQueryUnitOfWork unitOfWork) : base()
		{
		
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected AutoMapper.IMapper Mapper { get; }

		protected TadbirKish.Persistence.IQueryUnitOfWork UnitOfWork { get; }

		

		public async Task
			<FluentResults.Result<GetCoveragesQueryResponseViewModel>>
			Handle(Queries.GetByCodeQuery request, CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result
				<GetCoveragesQueryResponseViewModel>();

			try
			{

				var Coverages = await UnitOfWork.Coverages
                    .GetByCodeAsync(code: request.Code);
					;

				result.WithValue(value: Coverages);
			
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
