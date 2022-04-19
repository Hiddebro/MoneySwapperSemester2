using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyswapperDAL.DTOs;


namespace MoneyswapperDAL.Interfaces
{
    public interface IUserContext
    {
        public UserDTO getUser(string username);
        bool Login(string username, string password);
        public void UpdateMoney(UserDTO user);
        public UserDTO addUser(string username, string password, string email, int rs3, int osrs);

    }
}
