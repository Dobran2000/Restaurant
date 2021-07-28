using System;
using System.Collections.Generic;
using System.Text;

namespace Foods
{
   public class Fish:FoodItem
    {
        string PreparationMode { get; set; }


        public Fish(string name,int price,double portionSize,string preparationMode)
            :base(name,price,portionSize)
        {
            this.PreparationMode = preparationMode;

        }

        public override string Present()
        {
            return Id + " This is a fish with name " + Name + " ,price " + Price
                 + " portion Size " + PortionSize + " and the preparation-mode is " +
                 PreparationMode;
        }


    }
}
