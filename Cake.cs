using System;
using System.Collections.Generic;
using System.Text;

namespace Deserts
{
    public class Cake:DesertItem
    {
        private string Glaze { get; set; }

        public Cake(string name,int price,double portionSize,string glaze) : 
            base(name,price,portionSize)
        {
            this.Glaze = glaze;

        }
        public override string Present()
        {
            return Id +" This is a cake with name " + Name + " price " + Price
                + " portion size " + PortionSize + "with glaze " + Glaze;

        }
    }
}
