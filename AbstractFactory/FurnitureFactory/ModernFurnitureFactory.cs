using AbstractFactory.Furniture;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.FurnitureFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ITable CreateCoffeeTable()
        {
            return new ModernTable();
        }
    }
}
