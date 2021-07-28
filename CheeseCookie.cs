using System;
using System.Collections.Generic;
using System.Text;

namespace Deserts
{
   public class CheeseCookie : DesertItem
    {
        string TypeCheese { get; set; }
        public CheeseCookie(string name,int price,double portionSize,string typeCheese)
            :base(name,price,portionSize)
        {
            this.TypeCheese = typeCheese;
        }


        public override string Present()
        {
            return Id+ " This is a cheese-cookie with name " + Name + " price " + Price
               + " portion size " + PortionSize + " with cheese  " + TypeCheese;

        }


    }
}
