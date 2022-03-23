using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MoneyswapperDAL;

namespace moneyswapper
{
    public class User
    {
       public int UserID { get;  set; }   
        public string Username { get;  set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int OSRS { get; set; }

        public int RS3 { get; set; }

        public User(int userId , string username , string password , string email , int oSRS , int rs3)
        {
            UserID = userId;   
            Username = username;
            Password = password;    
            Email = email;  
            OSRS = oSRS;    
            RS3 = rs3;                  
        }

        public User(UserDTO dto)
        {
            UserID = dto.UserID;
            Username = dto.Username;
            Password = dto.Password;
            Email = dto.Email;
            OSRS = dto.OSRS;
            RS3 = dto.RS3;
        }


        public User()
        {
         
        }

        




    }
}
