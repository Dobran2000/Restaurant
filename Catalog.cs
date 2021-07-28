using System;
using System.Collections.Generic;
using System.Text;
using Foods;
using Beverages;
using Deserts;
namespace RestaurantCatalog
{
    public class Catalog
    {
        List<FoodItem> Fooditems = new List<FoodItem>();
        List<BeveragesItem> BeveragesItems = new List<BeveragesItem>();
        List<DesertItem> desertItems = new List<DesertItem>();
        public Catalog()
        {
            
            BuildFoodCatalog();

        }
        void BuildFoodCatalog()
        {
            var meat1 = new Meat("Ship", 30, 200);
            var meat2 = new Meat("Cow", 45, 300);

            var seafood1 = new SeaFood("shrimp", 100, 400, "Black-Sea");
            var seafood2 = new SeaFood("Octopus", 200, 500, "Caspic-Sea");

            var fish1 = new Fish("Salmon", 70, 350, "Fried");
            var fish2 = new Fish("Mackerel", 300, 100, "Sushi");

            var water1 = new Water("Borsec", 2, 0.5);
            var water2 = new Water("Tusnad", 3, 1);

            var wine1 = new Wine("Bordeaux", 200, 2,"France");
            var wine2 = new Wine("Premium", 150, 1.5,"Moldova");

            var juice1 = new Juice("Fanta", 10, 1, "orange");
            var juice2 = new Juice("Sprite", 10, 0.5, "lemon");

            var cake1 = new Cake("Mochi", 30, 100, "lemon");
            var cake2 = new Cake("Tiramisu", 40, 400, "coffe");

            var cheesecake1 = new CheeseCookie("CheeseCookie-king", 30, 1000, "cow-cheese");
            var cheesecake2 = new CheeseCookie("CheeseCookie-queen", 40, 3000, "ship-cheese");

            var icecream1 = new IceCream("Vanilla", 30, 300, "Lemon");
            var icecream2 = new IceCream("Chocolate", 40, 200, "Cherie");

          
            Fooditems.Add(meat1);
            Fooditems.Add(meat2);
            Fooditems.Add(seafood1);
            Fooditems.Add(seafood2);
            Fooditems.Add(fish1);
            Fooditems.Add(fish2);

            
            BeveragesItems.Add(water1);
            BeveragesItems.Add(water2);
            BeveragesItems.Add(wine1);
            BeveragesItems.Add(wine2);
            BeveragesItems.Add(juice1);
            BeveragesItems.Add(juice2);

           
            desertItems.Add(cake1);
            desertItems.Add(cake2);
            desertItems.Add(cheesecake1);
            desertItems.Add(cheesecake2);
            desertItems.Add(icecream1);
            desertItems.Add(icecream2);

        }

        public string GetCatalogDescription()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("**************FOOD***********************");

            foreach (var item in Fooditems)
            {
                builder.AppendLine(item.Present());
            }

            builder.AppendLine("**************BEVERAGE***********************");

            foreach (var item in BeveragesItems)
            {
                builder.AppendLine(item.Present());
            }
            builder.AppendLine("**************DESERT***********************");
            foreach (var item in desertItems)
            {
                builder.AppendLine(item.Present());
            }

            builder.AppendLine("We hope you like it");
            return builder.ToString();
        }

        public bool BuyItemById(int id, string typeCommand)
        {

          //  int totalPrice = 0;
            if (typeCommand == "FOOD")
            {
                foreach (var item in Fooditems)
                {
                    if (item.Id == id)
                    {

                        Fooditems.Remove(item);
                        return true;
                    }

                }

            }
            if (typeCommand == "BEVERAGE")
            {
                foreach (var item in BeveragesItems)
                {
                    if (item.Id == id)
                    {

                        BeveragesItems.Remove(item);
                        return true;
                    }

                }
            }
            if (typeCommand == "DESERT")
            {
                foreach (var item in desertItems)
                {
                    if (item.Id == id)
                    {

                        desertItems.Remove(item);
                        return true;
                    }

                }

            }
            return false;
        }


        public int TotalPrice()
        {
            int totalPrice = 0;
            foreach (var item in Fooditems)
            {
                totalPrice = totalPrice + item.Price;


            }
            foreach (var item in BeveragesItems)
            {
                totalPrice = totalPrice + item.Price;


            }
            foreach (var item in desertItems)
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
                return BeveragesItems.Count == 0;
                return desertItems.Count == 0;
            }

        }

        public bool AddItemToCatalog
            (string commandType)
        {
            
            if (commandType == "Meat")
            {
                Console.WriteLine("What type of meat ?");
                string name = Console.ReadLine();
                Console.WriteLine("What price ?");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the dimension of portion-size?");
                double portionSize = Console.Read();


                Meat newFoodItem = new Meat(name + DateTime.Now.Millisecond,
                    price, portionSize);
                Fooditems.Add(newFoodItem);
                return true;
            }
            if (commandType == "Fish")
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
            if (commandType == "SeaFood")
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
                Fooditems.Add(newFoodItem);
                return true;

            }
             if(commandType== "Water")
            {
                Console.WriteLine("Introduce the name");
                string name = Console.ReadLine();
                Console.WriteLine("What price? ");
                int price= int.Parse(Console.ReadLine());
                Console.WriteLine("What is the portion-size? ");
                double portionSize = Console.Read();
                Water newBeverageItem = new Water(name + DateTime.Now.Millisecond, price, portionSize);
                BeveragesItems.Add(newBeverageItem);
                return true;

            }
            if (commandType == "Wine")
            {
                Console.WriteLine("Introduce the name");
                string name = Console.ReadLine();
                Console.WriteLine("What price? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the portion-size? ");
                double portionSize = Console.Read();
                Console.WriteLine("Whats is the place of origin? ");
                string placeOfOrigin = Console.ReadLine();
                Wine newBeverageItem = new Wine(name 
                    + DateTime.Now.Millisecond, price, portionSize,placeOfOrigin);
                BeveragesItems.Add(newBeverageItem);
                return true;

            }
            if(commandType=="Juice")
            {
                Console.WriteLine("Introduce the name");
                string name = Console.ReadLine();
                Console.WriteLine("What price? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the portion-size? ");
                double portionSize = Console.Read();
                Console.WriteLine("Whats is the fruit ");
                string fruit = Console.ReadLine();
                Wine newBeverageItem = new Wine(name
                    + DateTime.Now.Millisecond, price, portionSize, fruit);
                BeveragesItems.Add(newBeverageItem);
                return true;

            }
            if (commandType=="Cake")
            {
                Console.WriteLine("Introduce the name");
                string name = Console.ReadLine();
                Console.WriteLine("What price? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the portion-size? ");
                double portionSize = Console.Read();
                Console.WriteLine("Whats is the glaze ");
                string glaze = Console.ReadLine();
                Cake newDesertItem = new Cake(name, price, portionSize, glaze) ;
                desertItems.Add(newDesertItem);
                return true;

            }
            if (commandType == "CheeseCookie")
            {
                Console.WriteLine("Introduce the name");
                string name = Console.ReadLine();
                Console.WriteLine("What price? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the portion-size? ");
                double portionSize = Console.Read();
                Console.WriteLine("Whats is the cheese ");
                string cheese = Console.ReadLine();
                CheeseCookie newDesertItem = new CheeseCookie(name, price, portionSize, cheese);
                desertItems.Add(newDesertItem);
                return true;

            }
            if (commandType == "IceCream")
            {
                Console.WriteLine("Introduce the name");
                string name = Console.ReadLine();
                Console.WriteLine("What price? ");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the portion-size? ");
                double portionSize = Console.Read();
                Console.WriteLine("Whats is the fruit ");
                string fruit = Console.ReadLine();
                IceCream newDesertItem = new IceCream(name, price, portionSize, fruit);
                desertItems.Add(newDesertItem);
                return true;

            }

            return false;

        }

    }
}
