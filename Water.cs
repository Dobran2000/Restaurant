using System;
using System.Collections.Generic;
using System.Text;

namespace Beverages
{
    public class Water:BeveragesItem
    {
        public Water(string name,int price,double portionSize):base(name,price,portionSize)
        {
            this.Name = name;
            this.Price = price;
            this.PortionSize = portionSize;

        }
        public override string Present()
        {
            return Id + "This is a water with name " + Name + " ,price " + Price
                + " and portion-size " + PortionSize;
        }

    }
}
