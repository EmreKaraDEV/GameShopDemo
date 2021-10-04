using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Services
{
    interface ISaleService
    {
        void Sale(Entities.Gamer gamer, Entities.Game game, Entities.Campaign campaing);
    }
}
