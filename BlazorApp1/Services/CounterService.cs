namespace BlazorApp1.Services;

/// <summary>
/// Simple, testable counter logic. Kept separate from the UI so it can be
/// unit tested by the CI pipeline.
/// </summary>
public class CounterService
{
    public int CurrentCount { get; private set; }

    public int Increment(int by = 1)
    {
        CurrentCount += by;
        return CurrentCount;
    }

    public void Reset()
    {
        CurrentCount = 0;
    }
}
