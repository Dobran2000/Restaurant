using System;
using System.Collections.Generic;
using System.Text;

namespace Foods
{
    public class Meat:FoodItem
    {
        public Meat(string name,int price,double portionSize):base(name,price,portionSize)
        {
            this.Name = name;
            this.Price = price;
            this.PortionSize = portionSize;

        }
        public override string Present()
        {
            return Id + "This is a meat with name " + Name + " with price " + Price
                + " and the portion Size is " + PortionSize;
        }



    }
}
