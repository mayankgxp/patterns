///The Decorator pattern allows adding behavior to objects dynamically without modifying their structure.

namespace patterns;

public interface IComponent
{
    void Execute();
}
public class ConcreteComponent : IComponent
{
    public void Execute()
    {
        Console.WriteLine("Concrete Execute.");
    }
}

public class Decorator: IComponent
{
    private readonly IComponent _component;
    public Decorator(IComponent component)
    {
        _component = component;
    }

    public void Execute()
    {
        _component.Execute();
        Console.WriteLine("Adding additional behavior in Decorator");
    }
}
