using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Services
{
    interface IGameService
    {
        public void AddGame(List<Entities.Game> games);
        public void UpdateGame(List<Entities.Game> games);
        public void DeleteGame(List<Entities.Game> games);
    }
}
