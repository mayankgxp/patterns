//The Observer pattern defines a subscription mechanism to notify multiple objects about any events that happen to the object they're observing.

namespace patterns;

public class Subject
{
    public event Action Notify;

    public void TriggerEvent()
    {
        Notify?.Invoke();
    }
}

public class Observer
{
    public void Notified()
    {
        Console.WriteLine("I am Notified.");
    }
}
