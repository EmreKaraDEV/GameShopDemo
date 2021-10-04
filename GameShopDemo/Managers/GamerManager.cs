using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Managers
{
    class GamerManager : Services.IGamerService
    {
        public int LastId=0;
        ValidationManager validationManager = new ValidationManager();
        
        public void AddGamer(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                if (validationManager.CheckIfRealPerson(gamer) == true)
                {
                    Console.WriteLine("New Gamer: " + gamer.FirstName + " " + gamer.LastName + " has been added.");
                }
                else
                {
                    Console.WriteLine("Invalid player! Failed to add.");
                }
            }
        }

        public void DeleteGamer(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                Console.WriteLine("Gamer: " + gamer.FirstName + " " + gamer.LastName + " has been deleted.");
            }          
        }

        public void UpdateGamer(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                Console.WriteLine("Current Gamer: " + gamer.FirstName + " " + gamer.LastName + " has been updated.");
            }
        }
    }
}
