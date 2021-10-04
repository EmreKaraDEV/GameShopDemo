using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Managers
{
    class SaleManager : Services.ISaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaing)
        {
            if(game.StockCount > 0)
            {
            again:;
                Console.WriteLine("\nInformation of the gamer who will buy the game --> Name: " + gamer.FirstName + " " + gamer.LastName);
                Console.WriteLine("Information of the game to be purchased --> Name: " + game.Name + " Price: " + game.Price);
                Console.WriteLine("Selected campaign details --> Name: "+campaing.Name+" Discount: "+campaing.GetDiscount()+"%");
                int totalAmount = game.Price - ((game.Price * campaing.GetDiscount()) / 100);
                Console.WriteLine("Game price after discount is applied: "+totalAmount);
                Console.WriteLine("Do you want buy this game?\n Write only \"yes\" or \"no\"\n");
                string decision = Console.ReadLine();
                switch (decision)
                {
                    case "yes":
                        Console.Clear();
                        Console.WriteLine("Thanks for buying this game!");
                        break;
                    case "no":
                        break;
                    default:
                        goto again;
                }
            }
            else
            {
                Console.WriteLine("You cant buy this game because not enough stock!");
            }
        }
    }
}
