namespace TadbirKish.Persistence.Base
{
	public interface IQueryUnitOfWork : IDisposable
	{
		bool IsDisposed { get; }
	}
}
