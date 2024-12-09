using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
    using System;

    // Abstract Product - Chair
    public interface IChair
    {
        void Create();
    }

    // Concrete Products - Chairs
    public class WoodenChair : IChair
    {
        public void Create() => Console.WriteLine("Wooden Chair Created.");
    }

    public class PlasticChair : IChair
    {
        public void Create() => Console.WriteLine("Plastic Chair Created.");
    }

    // Abstract Factory
    public interface IFurnitureFactory
    {
        IChair CreateChair();
    }

    // Concrete Factory for Wooden Furniture
    public class WoodenFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new WoodenChair();
    }

    // Concrete Factory for Plastic Furniture
    public class PlasticFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new PlasticChair();
    }

    // Client code
    class Program
    {
        static void Main(string[] args)
        {
            string furnitureType = "Wooden";  // Change to "Plastic" to test PlasticFurnitureFactory

            IFurnitureFactory furnitureFactory = null;

            // Using switch-case to choose the appropriate factory
            switch (furnitureType)
            {
                case "Wooden":
                    {
                        furnitureFactory = new WoodenFurnitureFactory();
                        break;
                    }

                case "Plastic":
                    {
                        furnitureFactory = new PlasticFurnitureFactory();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid furniture type.");
                        break;
                    }
            }

            // Create and display furniture if the factory is selected
            if (furnitureFactory != null)
            {
                IChair chair = furnitureFactory.CreateChair();

                chair.Create();
            }
        }
    }

}
