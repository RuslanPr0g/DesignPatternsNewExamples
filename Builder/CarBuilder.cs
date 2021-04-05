using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class CarBuilder : IBuilder
    {
        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SetEngine(IEngine engine)
        {
            throw new NotImplementedException();
        }

        public void SetGPS()
        {
            throw new NotImplementedException();
        }

        public void SetSeats(int quantity)
        {
            throw new NotImplementedException();
        }

        public void SetTripComputer()
        {
            throw new NotImplementedException();
        }
    }
}
