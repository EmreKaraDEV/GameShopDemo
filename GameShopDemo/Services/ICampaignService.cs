using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopDemo.Services
{
    interface ICampaignService
    {
        public void AddCampaign(List<Entities.Campaign> campaigns);
        public void UpdateCampaign(List<Entities.Campaign> campaigns);
        public void DeleteCampaign(List<Entities.Campaign> campaigns);
    }
}
