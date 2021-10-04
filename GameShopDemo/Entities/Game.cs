using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Entities
{
    class Game
    {
        public Game(int LastId)
        {
            this.Id = LastId;
        }
        
        private int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }

        public int GetId()
        {
            return this.Id;
        }
    }
}
