using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Managers
{
    class ValidationManager : Services.IValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.NationaltyId == "1923")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
