using FactoryMethod.Logistic;
using FactoryMethod.Transport;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Logistics r = new RoadLogistics();
            Logistics s = new SeaLogistics();

            r.PlanDelivery();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            s.PlanDelivery();
        }
    }
}
