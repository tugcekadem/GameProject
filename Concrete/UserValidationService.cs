using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationService : IUserValidationService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
