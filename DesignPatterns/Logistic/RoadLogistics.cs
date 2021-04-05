using FactoryMethod.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Logistic
{
    public class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Car();
        }
    }
}
