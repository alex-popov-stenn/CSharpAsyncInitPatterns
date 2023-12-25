namespace ConsoleRunner.Factory;

public class MyBestService
{
    public MyBestService()
    {
    }

    public async Task InitializeAsync(CancellationToken cancellationToken)
    {
        //diligently initializing

        await Task.Delay(100);
    }
}