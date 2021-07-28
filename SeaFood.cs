using System;
using System.Collections.Generic;
using System.Text;

namespace Foods
{
   public class SeaFood:FoodItem
    {
        private string PlaceOfOrigin { get; set; }
        
        public SeaFood(string name,int price,double portionSize, 
            string placeOfOrigin):base(name,price,portionSize)
        {
            this.PlaceOfOrigin = placeOfOrigin;

        }

        public override string Present()
        {
            return Id + " This is a seafood with name " + Name + ", price " + Price
                + " ,portion size  " + PortionSize + " and place of origin is " + PlaceOfOrigin;
            


        }


    }
}
