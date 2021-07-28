using System;
using Foods;
using RestaurantCatalog;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the our restaurant");

            Catalog restaurantCatalog = new Catalog();
            string catalogRestaurantDescription = restaurantCatalog.GetCatalogDescription();
            Console.WriteLine(catalogRestaurantDescription);

            while (true)
            {
                Console.WriteLine("What would you like to command? (ID) .Type ADD to add . Type END to stop");
                string command = Console.ReadLine();

                if (command == "END")
                {
                    Console.WriteLine("Have a nice day !");
                    break;
                }

                if (command == "ADD")
                {
                    Console.WriteLine("Types: Cookie, Cake, Fish, Meat, SeaFood, CheeseCookie, IceCream, Water, Wine, Juice");
                    Console.WriteLine("What type? ");
                    command = Console.ReadLine();
                    if (restaurantCatalog.AddItemToCatalog(command))
                    {
                        Console.WriteLine("New item in stock!");
                        catalogRestaurantDescription =
                            restaurantCatalog.GetCatalogDescription();
                        Console.WriteLine(catalogRestaurantDescription);
                        continue;


                    }
                    else
                    {
                        Console.WriteLine("Cannot add the type of food");
                        continue;

                    }
                }
                int itemFoodId = 0;
                if (!int.TryParse(command, out itemFoodId))
                {
                    Console.WriteLine("Invalid ID");
                    continue;

                }
                Console.WriteLine("Please introduce the type of command:FOOD,BEVERAGE OR DESERT");
                string typeCommand = Console.ReadLine();
                bool bought = restaurantCatalog.BuyItemById(itemFoodId,typeCommand);
                if (bought)
                {
                    Console.WriteLine("The price is " + restaurantCatalog.TotalPrice());
                    

                    Console.WriteLine("You have made a command");
                   
                    if (restaurantCatalog.IsEmpty)
                    {
                        Console.WriteLine("We have no more foods. Have a nice day !:)");
                        break;
                    }


                    catalogRestaurantDescription = restaurantCatalog.GetCatalogDescription();
                    Console.WriteLine(catalogRestaurantDescription);
                    

                }
                else
                {
                    Console.WriteLine("Command failed");
                }
                
            }
          
            Console.ReadLine();


        }

        
    }
}
