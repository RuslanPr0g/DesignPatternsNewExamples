using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Furniture
{
    public interface IChair
    {
        bool HasLegs();
        void SitOn();
    }
}
