using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Entities
{
    class Gamer
    {
        public Gamer(int LastId)
        {
            this.Id = LastId;
        }
        
        private int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string NationaltyId { get; set; }

        public int GetId()
        {
            return Id;
        }
    }
}
