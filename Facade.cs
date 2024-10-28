//The Facade pattern provides a simplified interface to a complex subsystem.

namespace patterns;

class SubSystemA
{
    public void OperationA()
    {
        Console.WriteLine("OperationA");
    }
}

class SubSystemB
{
    public void OperationB()
    {
        Console.WriteLine("OperationB");
    }
}

internal class Facade
{
    private SubSystemA subSystemA = new SubSystemA();
    private SubSystemB subSystemB = new SubSystemB();

    public void Operation()
    {
        subSystemA.OperationA();
        subSystemB.OperationB();
    }
}
