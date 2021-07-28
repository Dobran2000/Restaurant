using System;
using System.Collections.Generic;
using System.Text;

namespace Deserts
{
   public class IceCream:DesertItem
    {
        string Fruit { get; set; }


        public IceCream(string name,int price,double portionSize,string fruit)
            :base(name,price,portionSize)
        {
            this.Fruit = fruit;
        }
        public override string Present()
        {
            return Id+ " This is a cake with name " + Name + " price " + Price
                + " portion size " + PortionSize + "with fruit " + Fruit;
        }


    }
}
