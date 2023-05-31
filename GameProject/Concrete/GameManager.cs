using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class GameManager : IGameService
    {
        ICampaignService _campaignService;

        public GameManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            _campaignService.GetCampaing(campaign);
            Console.WriteLine("The Game is Sold, The Sold Game is : " + game.Name + " - The Person Who Bought : " + gamer.FirstName + " The Last Price of the Game = The Price of The Game : " + game.Price + " / Campaign Discount : " + campaign.Discount + " = " + (game.Price / campaign.Discount)  );
        }
    }
}
