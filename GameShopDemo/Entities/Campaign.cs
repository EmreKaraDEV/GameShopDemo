using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Entities
{
    class Campaign
    {
        public Campaign(int LastId)
        {
            this.Id = LastId;
        }
        
        private int Id { get; set; }
        public string Name { get; set; }
        private int Discount = 1;

        public int GetId()
        {
            return this.Id;
        }

        public int GetDiscount()
        {
            return Discount;
        }

        public void SetDiscount(int DiscountMin1Max100)
        {
            if(Discount >= 1 && Discount <= 100) {
                this.Discount = DiscountMin1Max100;
            }
            else {
                Console.WriteLine("Invalid value error : The discount amount can only be between 1 and 100. You cannot enter values less than 0 and 0, or values above 101 and 101!");
                Console.WriteLine(this.Name+" campaign discount rate is "+this.Discount+" now.");
            }
        }
    }
}
