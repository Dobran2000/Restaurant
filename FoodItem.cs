using System;
using System.Collections.Generic;
using System.Text;

namespace Foods
{
    public abstract class FoodItem
    {
        static int BaseId = 1;
        public int Id { get; set; }
        protected string Name { get; set; }

        public int Price { get; set; }

        protected double PortionSize { get; set; }

        public FoodItem(string name,int price,double portionSize)
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
