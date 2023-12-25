namespace ConsoleRunner.Factory;

public interface IMyBestServiceFactory
{
    Task<MyBestService> CreateAsync(CancellationToken cancellationToken);
}
