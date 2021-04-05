using AbstractFactory.Furniture;
using AbstractFactory.FurnitureFactory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modern things

            IFurnitureFactory furnitureFactory = new ModernFurnitureFactory();

            IChair chair = furnitureFactory.CreateChair();
            ITable table = furnitureFactory.CreateCoffeeTable();

            chair.HasLegs();
            chair.SitOn();

            table.Shape();
            table.SitNextTo();

            // Viktorian things

            furnitureFactory = new ViktorianFurnitureFactory();

            chair = furnitureFactory.CreateChair();
            table = furnitureFactory.CreateCoffeeTable();

            chair.HasLegs();
            chair.SitOn();

            table.Shape();
            table.SitNextTo();
        }
    }
}
