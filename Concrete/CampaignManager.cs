using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" "+ " kampanyası eklendi ");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" " + " kampanyası silindi ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName +" " + "kampanyası güncellendi");
        }
    }
}
