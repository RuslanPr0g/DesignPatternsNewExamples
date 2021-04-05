using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Furniture
{
    public class ModernChair : IChair
    {
        public bool HasLegs()
        {
            Console.WriteLine("It has no legs");
            return false;
        }

        public void SitOn()
        {
            Console.WriteLine("Someone is sitting on the chair, but on modern way");
        }
    }
}
