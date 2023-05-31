using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    //MicroService
    internal class GamerManager : IGamerService
    {
        UserValidationManager _userValidationManager;

        public GamerManager(UserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer))
            {
                Console.WriteLine("Gamer Added!");
            }
            else
            {
                Console.WriteLine("Validation is NOT TRUE! Registration Failed!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted!");
        }
    }
}
