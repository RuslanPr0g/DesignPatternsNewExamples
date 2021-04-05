using AbstractFactory.Furniture;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.FurnitureFactory
{
    public class ViktorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ViktorianChair();
        }

        public ITable CreateCoffeeTable()
        {
            return new ViktorianTable();
        }
    }
}
