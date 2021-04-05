using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Furniture
{
    public class ViktorianChair : IChair
    {
        public bool HasLegs()
        {
            Console.WriteLine("It has 4 legs");
            return true;
        }

        public void SitOn()
        {
            Console.WriteLine("Someone is sitting on the chair");
        }
    }
}
