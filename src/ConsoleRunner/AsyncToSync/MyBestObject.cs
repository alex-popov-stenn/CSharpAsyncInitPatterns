namespace ConsoleRunner.AsyncToSync;

public class MyBestObject
{
    public MyBestObject()
    {
        InitializeAsync().GetAwaiter().GetResult();
    }

    private async Task InitializeAsync()
    {
        //diligently initializing

        await Task.Delay(100);
    }
}
