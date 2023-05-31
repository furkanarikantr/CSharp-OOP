using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName is not null)
            {
                Console.WriteLine("Validation is OK!");
                return true;
            }
            else
            {
                Console.WriteLine("Validation is NOT OK!");
                return false;
            }
        }
    }
}
