namespace ConsoleRunner.AsyncInitialization;

public class MyBestService
{
    private readonly Task _initializeTask;

    public MyBestService()
    {
        _initializeTask = InitializeAsync();
    }

    public async Task DoSomethingAsync() 
    {
        await _initializeTask;

        // Do something async
    }

    private async Task InitializeAsync()
    {
        //diligently initializing

        await Task.Delay(100);
    }
}
