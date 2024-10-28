//The Strategy pattern enables selecting an algorithm’s behavior at runtime.


namespace patterns;

public interface IStrategy
{
    public void Execute();
}

public class StrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy A.");
    }
}
public class StrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Strategy B.");
    }
}
internal class Context : IStrategy
{
    private IStrategy _strategy;

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Execute()
    {
        _strategy.Execute();
    }
}
