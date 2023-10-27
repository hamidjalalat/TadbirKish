using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.Coverages.CommandHandlers
{
	public class GetCoveragesQueryHandler : object,
		Mediator.IRequestHandler
		<Queries.GetCoveragesQuery, System.Collections.Generic.IEnumerable<GetCoveragesQueryResponseViewModel>>
	{
		public GetCoveragesQueryHandler
            (
			AutoMapper.IMapper mapper,
            TadbirKish.Persistence.IQueryUnitOfWork unitOfWork) : base()
		{
		
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected AutoMapper.IMapper Mapper { get; }

		protected TadbirKish.Persistence.IQueryUnitOfWork UnitOfWork { get; }

		

		public
			async
		Task
			<FluentResults.Result
				<IEnumerable
				<GetCoveragesQueryResponseViewModel>>>
			Handle(Queries.GetCoveragesQuery request, System.Threading.CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result
				<System.Collections.Generic.IEnumerable
				<GetCoveragesQueryResponseViewModel>>();

			try
			{
			
				var Coverages =
					await
					UnitOfWork.Coverages
                    .GetSomeAsync()
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
