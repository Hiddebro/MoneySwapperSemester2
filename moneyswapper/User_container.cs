using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyswapperDAL;
using MoneyswapperDAL.Context;
using MoneyswapperDAL.DTOs;
using MoneyswapperDAL.Interfaces;

namespace moneyswapper
{
    public class User_container
    {
        private IUserContext UserContext;

        public User_container(IUserContext context)
        {
            UserContext = context;
        }
        public User GetUser(string username)
        {
            UserDTO userDTO = UserContext.getUser(username);

            return new User(userDTO);
        }

        public void Update(User user)
        {
            UserContext.UpdateMoney(user.ToDTO());
        }

        public User adduser(string username, string password, string email, int rs3, int osrs)
        {
            UserDTO dto = UserContext.addUser(username, password, email, rs3, osrs);

            return new User(dto);
        }



    }


}
