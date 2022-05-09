using System;

namespace MoneySwapperrASP.Models
{
    public class UserViewModel
    {
        public int UserID { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int OSRS { get; set; }

        public int RS3 { get; set; }

        public UserViewModel(int userID, string username, string password, string email, int oSRS, int rS3)
        {
            UserID = userID;
            Username = username;
            Password = password;
            Email = email;
            OSRS = oSRS;
            RS3 = rS3;

        }

        public UserViewModel()
        {

        }
    }
}
