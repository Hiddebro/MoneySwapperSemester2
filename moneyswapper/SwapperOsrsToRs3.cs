using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace moneyswapper
{
    class SwapperOsrsToRs3
    {


        public SwapperOsrsToRs3()
        {

        }

        public (int OSRS, int RS3, int TransferAmount, int SwapRateToRS3) OsrsToRs3(int OSRS, int RS3, int TransferAmount, int SwapRateToRS3)
        {
            if (OSRS >= TransferAmount)
            {
                RS3 = RS3 + TransferAmount * SwapRateToRS3;
                OSRS = OSRS - TransferAmount;
                TransferAmount = TransferAmount * SwapRateToRS3;

            }
            return (OSRS, RS3, TransferAmount, SwapRateToRS3);
        }


        public (int RS3, int TransferAmount, int SwapRateToRS3) transfer(int RS3, int TransferAmount, int SwapRateToRS3)
        {
            TransferAmount = TransferAmount * SwapRateToRS3 + RS3;
            return (RS3, TransferAmount, SwapRateToRS3);
        }


    }
}

