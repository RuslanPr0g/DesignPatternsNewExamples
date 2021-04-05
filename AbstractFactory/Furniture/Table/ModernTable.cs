using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Furniture
{
    public class ModernTable : ITable
    {
        public void Shape()
        {
            Console.WriteLine("Modern table has circular shape");
        }

        public void SitNextTo()
        {
            Console.WriteLine("Someone is sitting next to the modern table");
        }
    }
}
