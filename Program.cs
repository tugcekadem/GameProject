using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entity;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Tuğçe";
            player1.LastName = "Kadem";
            player1.DateOfBirth = new DateTime(2000, 11, 17);
            player1.NationaltyId = "123456789";

            Player player2 = new Player();
            player2.Id = 2;
            player2.FirstName = "Yiğit";
            player2.LastName = "Karademir";
            player2.DateOfBirth = new DateTime(1998, 7, 15);
            player2.NationaltyId = "987654321";

            PlayerManager playerManager1 = new PlayerManager(new MernisServiceAdapters());
            playerManager1.Add(player1);

            playerManager1.Update(player1);
            playerManager1.Delete(player2);


           

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "oyun 1";
            game1.GamePrice = 150;

            Game game2 = new Game();
            game2.Id = 2;
            game2.GameName = "oyun 2";
            game2.GamePrice = 100;

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(player1, game1);

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "kampanya 1";
            campaign1.DiscountRate = 50;



            Campaign campaign2 = new Campaign();
            campaign2.Id = 2;
            campaign2.CampaignName = "kampanya 2";
            campaign2.DiscountRate = 30;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign2);

            SalesManager salesManager1 = new SalesManager();
            salesManager1.CampaignSales(player1, game2, campaign1);


            




        }
    }
}
