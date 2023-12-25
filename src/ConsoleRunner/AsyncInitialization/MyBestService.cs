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
        //

        await Task.Delay(100);
    }
}