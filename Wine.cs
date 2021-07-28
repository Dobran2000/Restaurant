using System;
using System.Collections.Generic;
using System.Text;

namespace Beverages
{
    public class Wine:BeveragesItem
    {
        string PlaceOfOrigin { get; set; }
        public Wine(string name,int price,double portionSize,string placeOfOrigin ):base(name,price,portionSize)
        {
            this.PlaceOfOrigin = placeOfOrigin;
        }

        public override string Present()
        {
            return Id + "This is a wine with name " + Name + " ,price " + Price
                + " and portion-size " + PortionSize;
        }

    }
}
