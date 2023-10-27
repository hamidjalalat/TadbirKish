

using System.Resources;

namespace TadbirKish.Application.Coverages.CommandHandlers
{
	public class CreateCoverageCommandHandler : Mediator.IRequestHandler
		<Commands.CreateCoverageCommand, System.Guid>
	{
		public CreateCoverageCommandHandler
            (
			AutoMapper.IMapper mapper,
			Persistence.IUnitOfWork unitOfWork) : base()
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected AutoMapper.IMapper Mapper { get; }

		protected Persistence.IUnitOfWork UnitOfWork { get; }

		

		public async Task<FluentResults.Result<System.Guid>>
			Handle(Commands.CreateCoverageCommand request,
			CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result<System.Guid>();

			try
			{
                var Coverage = Mapper.Map<Domain.Models.Coverage>(source: request);
           
                await UnitOfWork.Coverages.InsertAsync(entity: Coverage);

                await UnitOfWork.SaveAsync();
             
                result.WithValue(value: Coverage.Id);
                string successInsert =
                    string.Format("عملیات درج با موفقیت انجام شد");

                result.WithSuccess
                    (successMessage: successInsert);
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
