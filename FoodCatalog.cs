using System;
using System.Collections.Generic;
using System.Text;

namespace Foods
{
   public class FoodCatalog
    {
        List<FoodItem> Fooditems = new List<FoodItem>();
        public FoodCatalog()
        {
            BuildFoodCatalog();

        }
        void BuildFoodCatalog()
        {
            var meat1 = new Meat("Ship", 30, 200);
            var meat2 = new Meat("Cow", 45, 300);

            var seafood1 = new SeaFood("shrimp", 100, 400,"Black-Sea");
            var seafood2 = new SeaFood("Octopus", 200, 500, "Caspic-Sea");

            var fish1 = new Fish("Salmon", 70, 350, "Fried");
            var fish2 = new Fish("Mackerel", 300, 100, "Sushi");

            Fooditems.Add(meat1);
            Fooditems.Add(meat2);
            Fooditems.Add(seafood1);
            Fooditems.Add(seafood2);
            Fooditems.Add(fish1);
            Fooditems.Add(fish2);

        }

      public string GetCatalogDescription()
      {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Here is our food catalog");

            foreach(var item in Fooditems)
            {
                builder.AppendLine(item.Present());
            }
            builder.AppendLine("We hope you like it");
            return builder.ToString();
      }

        public bool BuyItemById(int id)
        {
            List<int> Prices = new List<int>();
            int totalPrice = 0;
            foreach (var item in Fooditems)
            {
                if (item.Id == id)
                {

                    Fooditems.Remove(item);
                    Prices.Add(totalPrice);
                    return true;
                }

            }

            return false;

        }
        

            public int TotalPrice()
            {
            int totalPrice = 0;
            foreach(var item in Fooditems)
            {
                totalPrice = totalPrice + item.Price;
                
                
            }

            return totalPrice;
            
            }

        




        public bool IsEmpty
        {
            get
            {
                return Fooditems.Count == 0;

            }
        }

        public bool AddItemToCatalog
            (string foodType)
        {
            if(foodType=="Meat")
            {
                Console.WriteLine("What type of meat ?");
                string name = Console.ReadLine();
                Console.WriteLine("What price ?");
                int price= int.Parse(Console.ReadLine());
                Console.WriteLine("What is the dimension of portion-size?");
                double portionSize = Console.Read();


                Meat newFoodItem = new Meat(name + DateTime.Now.Millisecond,
                    price,portionSize);
                Fooditems.Add(newFoodItem);
                return true;
            }
           if(foodType=="Fish")
            {
                Console.WriteLine("Introduce please the preparation-Mode");
                string preparationMode = Console.ReadLine();
                Console.WriteLine("What type of fish ?");
                string name = Console.ReadLine();
                Console.WriteLine("What price ?");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the dimension of portion-size?");
                double portionSize = Console.Read();

                Fish newFoodItem = new Fish(name + DateTime.Now.Millisecond,
                    price, portionSize, preparationMode);
                Fooditems.Add(newFoodItem);
                return true;

            }
           if(foodType=="SeaFood")
            {
                Console.WriteLine("Introduce please the preparation-Mode");
                string preparationMode = Console.ReadLine();
                Console.WriteLine("What type of fish ?");
                string name = Console.ReadLine();
                Console.WriteLine("What price ?");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the dimension of portion-size?");
                double portionSize = Console.Read();
                Console.WriteLine("Introduce the place of origin ");
                string placeOfOrgigin = Console.ReadLine();
                SeaFood newFoodItem = new SeaFood(name + DateTime.Now.Millisecond
                    , price, portionSize, placeOfOrgigin);

            }

            return false;

        }






    }
}
