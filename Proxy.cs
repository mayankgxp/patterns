//The Proxy pattern provides a surrogate or placeholder for another object to control access to it.

namespace patterns;

public interface IRequest
{
    void Reqest();
}

public class RealService : IRequest
{
    public void Reqest()
    {
        Console.WriteLine("Request called.");
    }
}

internal class Proxy: IRequest
{
    private RealService realService;

    public void Reqest()
    {
        if (realService == null)
        {
            realService = new RealService();
        }

        realService.Reqest();
    }
}
