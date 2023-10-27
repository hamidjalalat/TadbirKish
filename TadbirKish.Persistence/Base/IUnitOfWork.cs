namespace TadbirKish.Persistence.Base
{
	public interface IUnitOfWork : IQueryUnitOfWork
	{
		Task SaveAsync();
	}
}
