using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Furniture
{
    public class ViktorianTable : ITable
    {
        public void Shape()
        {
            Console.WriteLine("Viktorian table has rectangular shape");
        }

        public void SitNextTo()
        {
            Console.WriteLine("Someone is sitting next to the viktorian table");
        }
    }
}
