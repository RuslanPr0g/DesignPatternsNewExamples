using FactoryMethod.Transport;
using System;
using System.Threading;

namespace FactoryMethod.Logistic
{
    public abstract class Logistics
    {
        public void PlanDelivery()
        {
            Console.WriteLine("Planning delivery... |-----");
            Thread.Sleep(800);
            Console.WriteLine("Planning delivery... ||||--");
            Thread.Sleep(500);
            Console.WriteLine("Planning delivery... |||||-");
            Thread.Sleep(1500);
            Console.WriteLine("Delivery planned successfully!");

            ITransport transport = CreateTransport();
            transport.Deliver();
        }

        public abstract ITransport CreateTransport();
    }
}
