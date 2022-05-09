using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoneySwapperrASP.Models;
using Microsoft.AspNetCore.Http;
using MoneyswapperDAL.DTOs;
using BusinessLayer.Models;
using MoneySwapperrASP.ViewModels;
using MoneySwapperrASP.VMConverters;
using BusinessLayer.Container;



namespace MoneySwapperrASP.Controllers
{
    public class UserController : Controller
    {
        private readonly UserVMC viewModelConverter = new UserVMC();
        private readonly User_Container user_Container;
    

        public UserController(User_Container container)
        {
            this.user_Container = container;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Register(UserViewModel vm)
        {
            if (ModelState.IsValid)
            {
                UserModel user = viewModelConverter.ViewModelToModel(vm);
                user_Container.Insert(User);
                return View("Login");
            }
            return RedirectToAction("Login", "User", vm);
        }
        public IActionResult Login(UserViewModel userVM)
        {
            if (ModelState.IsValid)
            {
                userVM = VMConverters.ModelToViewModel(user_Container.GetByName(viewModelConverter.ViewModelToModel(accountVM)));

                if (userVM.UserID != 0)
                {
                    HttpContext.Session.SetString("User", JsonConvert.SerializeObject(userVM));

                }
                return View();
            }
            return View();
        }
    }
}
