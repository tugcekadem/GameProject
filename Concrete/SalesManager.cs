using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SalesManager
    {
        public void Sales(Player player,Game game)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName +" " + game.GameName +" oyununu " + game.GamePrice+" TL'ye satın aldı ");
        }

        public void CampaignSales(Player player,Game game, Campaign campaign)
        {
            int Account = game.GamePrice - ((game.GamePrice * campaign.DiscountRate) / 100);
            Console.WriteLine(player.FirstName + " " + player.LastName + ", " + game.GameName + " oyununu " + campaign.CampaignName + " kampanyası ile %" + campaign.DiscountRate + " indirimle " + Account + " TL'ye satın aldı.");
        }
    }
}
