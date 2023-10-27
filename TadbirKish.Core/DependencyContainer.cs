using MediatR;
using FluentValidation;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace TadbirKish.Core
{
	public static class DependencyContainer : object
	{
		static DependencyContainer()
		{
		}

		public static void ConfigureServices
			(Microsoft.Extensions.Configuration.IConfiguration configuration,
			Microsoft.Extensions.DependencyInjection.IServiceCollection services)
		{
			services.AddTransient
				<Microsoft.AspNetCore.Http.IHttpContextAccessor,
				Microsoft.AspNetCore.Http.HttpContextAccessor>();

		

			// AddMediatR -> Extension Method -> using MediatR;
			// GetTypeInfo -> Extension Method -> using System.Reflection;
			services.AddMediatR
				(typeof(TadbirKish.Application.Users.MappingProfile).GetTypeInfo().Assembly);

			// AddValidatorsFromAssembly -> Extension Method -> using FluentValidation;
			services.AddValidatorsFromAssembly
				(assembly: typeof(TadbirKish.Application.RequestRegistrations.Commands.CreateRequestRegistrationCommandValidator).Assembly);

			services.AddTransient
				(typeof(MediatR.IPipelineBehavior<,>), typeof(Mediator.ValidationBehavior<,>));

			// using Microsoft.Extensions.DependencyInjection;
			services.AddAutoMapper
				(profileAssemblyMarkerTypes: typeof(TadbirKish.Application.Users.MappingProfile));

			services.AddTransient<TadbirKish.Persistence.IUnitOfWork, TadbirKish.Persistence.UnitOfWork>(current =>
			{
				string databaseConnectionString =
					configuration
					.GetSection(key: "ConnectionStrings")
					.GetSection(key: "CommandsConnectionString")
					.Value;

				string databaseProviderString =
					configuration
					.GetSection(key: "CommandsDatabaseProvider")
					.Value;

                TadbirKish.Base.Enums.Provider databaseProvider =
					(TadbirKish.Base.Enums.Provider)
					System.Convert.ToInt32(databaseProviderString);

                TadbirKish.Persistence.Base.Options options =
					new TadbirKish.Persistence.Base.Options
					{
						Provider = databaseProvider,
						ConnectionString = databaseConnectionString,
					};

				return new TadbirKish.Persistence.UnitOfWork(options: options);
			});

			services.AddTransient<TadbirKish.Persistence.IQueryUnitOfWork, TadbirKish.Persistence.QueryUnitOfWork>(current =>
			{
				string databaseConnectionString =
					configuration
					.GetSection(key: "ConnectionStrings")
					.GetSection(key: "QueriesConnectionString")
					.Value;

				string databaseProviderString =
					configuration
					.GetSection(key: "QueriesDatabaseProvider")
					.Value;

                TadbirKish.Base.Enums.Provider databaseProvider =
					(TadbirKish.Base.Enums.Provider)
					System.Convert.ToInt32(databaseProviderString);

                TadbirKish.Persistence.Base.Options options =
					new TadbirKish.Persistence.Base.Options
					{
						Provider = databaseProvider,
						ConnectionString = databaseConnectionString,
					};

				return new TadbirKish.Persistence.QueryUnitOfWork(options: options);
			});
		}
	}
}
