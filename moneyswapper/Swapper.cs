using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyswapperDAL.Context;
using MoneyswapperDAL.DTOs;
using MoneyswapperDAL.Interfaces;



namespace moneyswapper
{
    class Swapper
    {

        
        public Swapper()
        {
            var context = new TransferHandlerContext();
            transfer = new TransferHandler_Container(context).GetSwaprate();
            
        }

        public TransferHandler transfer { get; private set; }
        

        public (int OSRS, int RS3) OsrsToRs3(int OSRS, int RS3, int TransferAmount)
        {
            if (OSRS >= TransferAmount)
            {
                RS3 = RS3 + TransferAmount * transfer.SwapRateToRS3;
                OSRS = OSRS - TransferAmount;
                TransferAmount = TransferAmount * transfer.SwapRateToRS3;

            }
            return (OSRS, RS3);
        }

        public (int OSRS, int RS3) Rs3ToOsrs(int OSRS, int RS3, int TransferAmount)
        {
            if (RS3 >= TransferAmount && transfer.SwapRateToOSRS <= TransferAmount)
            {
                OSRS = TransferAmount / transfer.SwapRateToOSRS + OSRS;
                RS3 = RS3 - TransferAmount;
                TransferAmount = TransferAmount / transfer.SwapRateToOSRS;

            }
            return (OSRS, RS3);
        }

        public (int RS3, int TransferAmount) Transfer(int RS3, int TransferAmount)
        {
            TransferAmount = TransferAmount * transfer.SwapRateToRS3 + RS3;
            return (RS3, TransferAmount);
        }

        public (int OSRS, int TransferAmount) Transfer1(int OSRS, int TransferAmount)
        {
            TransferAmount = OSRS + TransferAmount / transfer.SwapRateToOSRS;
            return (OSRS, TransferAmount);
        }
    }
}

