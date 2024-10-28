using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
    public interface IProduct
    {
        string GetName();
    }

    public class ConcreteProductA : IProduct
    {
        public string GetName()
        {
            return "Product A";
        }
    }

    public class ConcreteProductB: IProduct
    {
        public string GetName()
        {
            return "Product B";
        }
    }

    internal class FactoryPattern
    {
        public static IProduct GetProduct(string type)
        {
            if(type == "A")
                return new ConcreteProductA();
            if(type == "B")
                return new ConcreteProductB();
            return new ConcreteProductA();
        }
    }
}
