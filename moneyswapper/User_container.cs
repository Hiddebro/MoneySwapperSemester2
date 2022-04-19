using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyswapperDAL;
using MoneyswapperDAL.Context;
using MoneyswapperDAL.DTOs;

namespace moneyswapper
{
    public class User_container
    {
        private UserContext userContext = new UserContext();
        public User GetUser(string username)
        {
            UserDTO userDTO = userContext.getUser(username);

            return new User(userDTO);
        }

        public void Update(User user)
        {
            userContext.UpdateMoney(user.ToDTO());
        }

        public User adduser(string username, string password, string email, int rs3, int osrs)
        {
            UserDTO dto = userContext.addUser(username, password, email, rs3, osrs);

            return new User(dto);
        }



    }


}
