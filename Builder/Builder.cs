using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int quantity);
        void SetEngine(IEngine engine);
        void SetTripComputer();
        void SetGPS();
    }
}
