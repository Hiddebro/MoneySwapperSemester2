using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MoneyswapperDAL;
using MoneyswapperDAL.DTOs;

namespace moneyswapper
{
    public class User
    {

        private Swapper swapper = new Swapper();


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

        public UserDTO ToDTO()
        {
            return new UserDTO
            {
                UserID = UserID,
                Username = Username,
                Password = Password,
                Email = Email,
                OSRS = OSRS,
                RS3 = RS3
            };
        }


        public bool SwapRs3ToOsrs(int amount)
        {
            if (amount <= RS3)
            {
                (OSRS, RS3) = swapper.Rs3ToOsrs(OSRS, RS3, amount);
                return true;
            }

            return false;


        }

        public bool SwapOsrsToRs3(int amount)
        {
            if (amount <= RS3)
            {
                (OSRS, RS3) = swapper.OsrsToRs3(OSRS, RS3, amount);
                return true;
            }

            return false;
        }




    }
}
