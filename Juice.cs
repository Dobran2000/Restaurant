using System;
using System.Collections.Generic;
using System.Text;

namespace Beverages
{
   public class Juice:BeveragesItem
    {
        string Fruit { get; set; }
        public Juice(string name,int price,double portionSize,string fruit)
            :base(name,price,portionSize)
        {
            this.Fruit = fruit;


        }
        public override string Present()
        {
            return Id + "This is a juice with name " + Name + " ,price " + Price
               + " and portion-size " + PortionSize+ " with fruit "+Fruit;
        }


    }
}
