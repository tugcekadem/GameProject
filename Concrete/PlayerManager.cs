using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class PlayerManager : IPlayerManager
    {
        private IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.LastName + " " + player.FirstName + " oyuncusu eklendi ");
            }
            else
            {
                Console.WriteLine(" Kayıt Başarısız");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.LastName +" " + player.FirstName + " Oyuncusu Silindi " );
        }

        public void Update(Player player)
        {
            if (_userValidationService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.LastName +"" + player.FirstName+" Oyuncusu Güncellendi ");
            }
            else
            {
                Console.WriteLine(" Kayıt Başarısız ");
            }
        }
    }
}
