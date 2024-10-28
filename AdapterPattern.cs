using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
    public interface IClientRequest
    {
        public void ProcessRequst();
    }

    public class LegacySystem
    {
        public void LegacyMethod()
        {
            Console.WriteLine("Legacy Method.");
        }
    }

    public class RequestAdapter: IClientRequest
    {
        LegacySystem ls = new();
        public void ProcessRequst()
        {
            ls.LegacyMethod();
        }
    }
}
