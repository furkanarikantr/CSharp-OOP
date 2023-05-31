using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void GetCampaing(Campaign campaign)
        {
            Console.WriteLine("The Campaign was Implemented. Campaign Name : " + campaign.Name + " - Campaign Discount Amount : " + campaign.Discount);
        }
    }
}
