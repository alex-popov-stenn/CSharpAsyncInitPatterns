namespace ConsoleRunner.Factory;

public class MyBestService
{
    public MyBestService()
    {
    }

    public async Task InitializeAsync(CancellationToken cancellationToken)
    {
        //

        await Task.Delay(100);
    }
}