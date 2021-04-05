using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Transport
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by ship.");
        }
    }
}
