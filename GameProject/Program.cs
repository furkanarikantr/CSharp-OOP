using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() {Id = 1, FirstName = "Furkan", LastName = "Arıkan", IdentityNumber = 17822017840};
            Game game1 = new Game() { Id = 1, Name = "Diablo", Price = 100 };
            Campaign campaign1 = new Campaign() { Id = 1, Name = "Diablo Game Campaign", Discount = 5 };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            GameManager gameManager = new GameManager(new CampaignManager());

            gamerManager.Add(gamer1);
            gameManager.Sale(game1, gamer1, campaign1);
        }
    }
}