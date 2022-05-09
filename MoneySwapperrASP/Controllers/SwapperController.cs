using Microsoft.AspNetCore.Mvc;
using MoneySwapperrASP.Models;
using MoneyswapperDAL;
using System;
using MoneyswapperDAL.Context;
using MoneyswapperDAL.Interfaces;
using MoneyswapperDAL.DTOs;


namespace MoneySwapperrASP.Controllers
{
    public class SwapperController : Controller
    {


        public IActionResult Index()
        {
            

            (int OSRS, int RS3) OsrsToRs3(int OSRS, int RS3, int TransferAmount)
            {
            TransferHandlerModel transfer = new TransferHandlerModel();
            if (OSRS >= TransferAmount)
                {
                    RS3 = RS3 + TransferAmount * transfer.SwapRateToRS3;
                    OSRS = OSRS - TransferAmount;
                    TransferAmount = TransferAmount * transfer.SwapRateToRS3;

                }
                return (OSRS, RS3);
            }

            (int OSRS, int RS3) Rs3ToOsrs(int OSRS, int RS3, int TransferAmount)
            {
            TransferHandlerModel transfer = new TransferHandlerModel();
            if (RS3 >= TransferAmount && transfer.SwapRateToOSRS <= TransferAmount)
                {
                    OSRS = TransferAmount / transfer.SwapRateToOSRS + OSRS;
                    RS3 = RS3 - TransferAmount;
                    TransferAmount = TransferAmount / transfer.SwapRateToOSRS;

                }
                return (OSRS, RS3);
            }

            (int RS3, int TransferAmount) Transfer(int RS3, int TransferAmount)
            {
            TransferHandlerModel transfer = new TransferHandlerModel();
            TransferAmount = TransferAmount * transfer.SwapRateToRS3 + RS3;
                return (RS3, TransferAmount);
            }

            (int OSRS, int TransferAmount) Transfer1(int OSRS, int TransferAmount)
            {
            TransferHandlerModel transfer = new TransferHandlerModel();
            TransferAmount = OSRS + TransferAmount / transfer.SwapRateToOSRS;
                return (OSRS, TransferAmount);
            }

            TransferHandlerModel transfer = new TransferHandlerModel();
            UserViewModel user = new UserViewModel();
            user.OSRS = 1000;
            user.RS3 = 1000;
            transfer.TransferAmount = 10;
           

            return View(transfer);
        }


    }
}





