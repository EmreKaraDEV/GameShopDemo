using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Managers
{
    class GameManager : Services.IGameService
    {
        public int LastId=0;
        
        public void AddGame(List<Game> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine("New Game: " + game.Name + " has been added.");
            }
        }

        public void UpdateGame(List<Game> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine("Current Game: " + game.Name + " has been updated.");
            }
        }

        public void DeleteGame(List<Game> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine("Game: " + game.Name + " has been deleted.");
            }
        }
    }
}
