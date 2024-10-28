//The Command pattern turns a request into a stand-alone object that contains all information about the request.

namespace patterns;

public interface ICommand
{
    void Execute();
}

public class Light
{
    public void On()
    {
        Console.WriteLine("Lights are on.");
    }
}

public class LightCommand : ICommand
{
    private readonly Light _light;
    public LightCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.On();

    }
}
