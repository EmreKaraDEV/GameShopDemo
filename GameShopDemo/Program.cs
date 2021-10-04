using System;
using System.Collections.Generic;

namespace GameShopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Games
            Managers.GameManager gameManager = new Managers.GameManager();
            Entities.Game game1 = new Entities.Game(++gameManager.LastId);
            game1.Name = "Forza Horizon 4";
            game1.Price = 150;
            game1.StockCount = 100;

            Entities.Game game2 = new Entities.Game(++gameManager.LastId);
            game2.Name = "Gta V";
            game2.Price = 180;
            game2.StockCount = 120;

            Entities.Game game3 = new Entities.Game(++gameManager.LastId);
            game3.Name = "Minecraft : Bedrock Edition";
            game3.Price = 85;
            game3.StockCount = 80;

            List<Entities.Game> games = new List<Entities.Game> { game1, game2, game3};
            #endregion

            #region Gamers
            Managers.GamerManager gamerManager = new Managers.GamerManager();
            Entities.Gamer gamer1 = new Entities.Gamer(++gamerManager.LastId);
            gamer1.FirstName = "Kaan Mehmet";
            gamer1.LastName = "Yıldız";
            gamer1.BirthYear = 2006;
            gamer1.NationaltyId = "1923";

            Entities.Gamer gamer2 = new Entities.Gamer(++gamerManager.LastId);
            gamer2.FirstName = "Emre";
            gamer2.LastName = "Kara";
            gamer2.BirthYear = 2001;
            gamer2.NationaltyId = "1923";

            Entities.Gamer gamer3 = new Entities.Gamer(++gamerManager.LastId);
            gamer3.FirstName = "Ahmet Mahmut Necmi";
            gamer3.LastName = "Yılmaz";
            gamer3.BirthYear = 2003;
            gamer3.NationaltyId = "1923";

            List<Entities.Gamer> gamers = new List<Entities.Gamer> { gamer1, gamer2, gamer3 };
            #endregion

            #region Campaigns
            Managers.CampaignManager campaignManager = new Managers.CampaignManager();
            Entities.Campaign campaign1 = new Entities.Campaign(++campaignManager.LastId);
            campaign1.Name = "Summer Discounts";
            campaign1.SetDiscount(40); 
            //Discounts must be between 1 and 100!
            Entities.Campaign campaign2 = new Entities.Campaign(++campaignManager.LastId);
            campaign2.Name = "Fall Discounts";
            campaign2.SetDiscount(40);

            List<Entities.Campaign> campaigns = new List<Entities.Campaign> { campaign1, campaign2 };
            #endregion

            gameManager.AddGame(games); gameManager.UpdateGame(games); gameManager.DeleteGame(games);
            gamerManager.AddGamer(gamers); gamerManager.UpdateGamer(gamers); gamerManager.DeleteGamer(gamers);
            campaignManager.AddCampaign(campaigns); campaignManager.UpdateCampaign(campaigns); campaignManager.DeleteCampaign(campaigns);

            Managers.SaleManager saleManager = new Managers.SaleManager();
            saleManager.Sale(gamer2, game1, campaign1);
        }
    }
}
