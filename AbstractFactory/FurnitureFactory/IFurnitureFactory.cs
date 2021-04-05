using AbstractFactory.Furniture;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.FurnitureFactory
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateCoffeeTable();
    }
}
