using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.RequestRegistrations.CommandHandlers
{
	public class GetRequestRegistrationsQueryHandler : object,
		Mediator.IRequestHandler
		<Queries.GetRequestRegistrationsQuery, System.Collections.Generic.IEnumerable<GetRequestRegistrationsQueryResponseViewModel>>
	{
		public GetRequestRegistrationsQueryHandler
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
				<GetRequestRegistrationsQueryResponseViewModel>>>
			Handle(Queries.GetRequestRegistrationsQuery request, System.Threading.CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result
				<System.Collections.Generic.IEnumerable
				<GetRequestRegistrationsQueryResponseViewModel>>();

			try
			{
			
				var RequestRegistrations =
					await
					UnitOfWork.RequestRegistrations
                    .GetSomeAsync(count: request.Count.Value)
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
