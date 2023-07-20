using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace VotingApplication
{
    public class UserManager
    {
        private List<User> _users;
        public UserManager()
        {
            _users = new List<User>()
            {
                new User{Id = 1, FirstName = "Süleyman", LastName = "Seba",UserName = "buyukbaskan",Password = "Bjk1903"},
                new User{Id = 2, FirstName = "Hakkı", LastName = "Yeten",UserName = "babahakki",Password = "Bjk1903"},
                new User{Id = 3, FirstName = "Recep", LastName = "Çetin",UserName = "takoz",Password = "Bjk1903"},
                new User{Id = 4, FirstName = "Feyyaz", LastName = "Uçar",UserName = "kibarfeyzo",Password = "Bjk1903"},
                new User{Id = 5, FirstName = "Ali", LastName = "Gültiken",UserName = "buyukgolcu",Password = "Bjk1903"},
                new User{Id = 6, FirstName = "Gökhan", LastName = "Keskin",UserName = "sonbarikat",Password = "Bjk1903"},
                new User{Id = 7, FirstName = "Ricardo", LastName = "Quaresma",UserName = "trivela",Password = "Bjk1903"},
                new User{Id = 8, FirstName = "Federico", LastName = "Guinti",UserName = "italyan",Password = "Bjk1903"},
                new User{Id = 9, FirstName = "İlhan", LastName = "Mansız",UserName = "imansiz",Password = "Bjk1903"},
                new User{Id = 10, FirstName = "Sergen", LastName = "Yalçın",UserName = "buyukonnumara",Password = "Bjk1903"},
                new User{Id = 11, FirstName = "Metin", LastName = "Tekin",UserName = "sarifirtina",Password = "Bjk1903"}
            };
        }
        
        public List<User> GetAll()
        {
            return _users;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}

