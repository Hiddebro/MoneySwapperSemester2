using System;
using BusinessLayer.Models;
using MoneySwapperrASP.Models;

namespace MoneySwapperrASP.VMConverters
{
    public class UserVMC
    {
        public UserModel ViewModelToModel(UserViewModel vmodel)
        {
            UserModel um = new UserModel()
            {
                UserID = vmodel.UserID,
                Username = vmodel.Username,
                Password = vmodel.Password,
                Email = vmodel.Email,
                OSRS = vmodel.OSRS,
                RS3 = vmodel.RS3
            };
            return um;
        }

        
        public UserViewModel ModelToViewModel(UserViewModel model)
        {
            UserViewModel vm = new UserViewModel()
            {
                UserID = model.UserID,
                Username = model.Username,
                Password = model.Password,
                Email = model.Email,
                OSRS = model.OSRS,
                RS3 = model.RS3
            };
            return vm;
        }

    }
}
