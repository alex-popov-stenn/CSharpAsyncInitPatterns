namespace ConsoleRunner.Factory;

public sealed class MyBestServiceFactory : IMyBestServiceFactory
{
    public MyBestServiceFactory()
    {
    }
    public async Task<MyBestService> CreateAsync(CancellationToken cancellationToken)
    {
        var service = new MyBestService();
        await service.InitializeAsync(cancellationToken);
        return service;
    }
}