using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Transport
{
    public class Car : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by car.");
        }
    }
}
