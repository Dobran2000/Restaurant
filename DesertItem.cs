using System;
using System.Collections.Generic;
using System.Text;

namespace Deserts
{
  public  abstract class DesertItem
    {
        static int BaseId = 1;
        public int Id { get; set; }
        protected string Name { get; set; }

        public int Price { get; set; }

        protected  double PortionSize { get; set; }

        public DesertItem(string name, int price, double portionSize)
        {

            this.Name = name;
            this.Price = price;
            this.PortionSize = portionSize;
            this.Id = BaseId;
            BaseId = BaseId + 1;
        }

        public abstract string Present();


    }
}
