using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyswapperDAL.DTOs;
using MoneyswapperDAL.Interfaces;
using BusinessLayer.Converters;
using BusinessLayer.Models;


namespace BusinessLayer.Container
{
    public class User_Container
    {
        private IUserContext UserContext;
        private readonly UserConverter converter = new UserConverter();

        
        public User_Container(IUserContext context, UserConverter uc)
        {
            UserContext = context;
            converter = uc;
        }

        public UserModel GetUser(string username)
        {
            UserDTO userDTO = UserContext.getUser(username);
            UserModel model = converter.DtoToModel(userDTO);

            return model;
        }

        public void Update(UserModel user)
        {
            UserContext.UpdateMoney(converter.ModelToDTO(user));
        }

        public UserModel adduser(string username, string password, string email, int rs3, int osrs)
        {
            UserDTO dto = UserContext.addUser(username, password, email, rs3, osrs);
            UserModel userModel = converter.DtoToModel(dto);

            return userModel;
        }



    }


}
