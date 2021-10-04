using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Services
{
    interface IGamerService
    {
        public void AddGamer(List<Entities.Gamer> gamers);
        public void UpdateGamer(List<Entities.Gamer> gamers);
        public void DeleteGamer(List<Entities.Gamer> gamers);
    }
}
