using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;
using MoneyswapperDAL.DTOs;
using MoneyswapperDAL.Interfaces;


namespace BusinessLayer.Converters
{
    public class UserConverter
    {
        public UserModel DtoToModel(UserDTO dto)
        {
            UserModel userModel = new UserModel()
            {
                UserID = dto.UserID,
            Username = dto.Username,
            Password = dto.Password,
            Email = dto.Email,
            OSRS = dto.OSRS,
            RS3 = dto.RS3
        };
            return userModel;
        }

        
        public UserDTO ModelToDTO(UserModel model)
        {
            UserDTO dto = new UserDTO()
            {
                UserID = model.UserID,
        Username = model.Username,
        Password = model.Password,
        Email = model.Email,
        OSRS = model.OSRS,
        RS3 = model.RS3

    };
            return dto;
        }
    }
}
