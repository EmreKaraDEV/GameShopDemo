using GameShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Managers
{
    class CampaignManager : Services.ICampaignService
    {
        public int LastId=0;
        
        public void AddCampaign(List<Campaign> campaigns)
        {
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("New Campaign: " + campaign.Name + " has been added.");
            }
        }

        public void UpdateCampaign(List<Campaign> campaigns)
        {
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("Current Campaign: " + campaign.Name + " has been updated.");
            }
        }

        public void DeleteCampaign(List<Campaign> campaigns)
        {
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("Campaign: " + campaign.Name + " has been deleted.");
            }
        }

        
    }
}
