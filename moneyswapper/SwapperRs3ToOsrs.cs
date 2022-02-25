using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moneyswapper
{
    class SwapperRs3ToOsrs
    {


        public SwapperRs3ToOsrs()
        {

        }

        public (int OSRS, int RS3, int TransferAmount, int SwapRateToOSRS) Rs3ToOsrs(int OSRS, int RS3, int TransferAmount, int SwapRateToOSRS)
        {
            if (RS3 >= TransferAmount && SwapRateToOSRS <= TransferAmount)
            {
                OSRS = TransferAmount / SwapRateToOSRS + OSRS;
                RS3 = RS3 - TransferAmount;
                TransferAmount = TransferAmount / SwapRateToOSRS;

            }
            return (OSRS, RS3, TransferAmount, SwapRateToOSRS);
        }


        public (int OSRS, int TransferAmount, int SwapRateToOSRS) transfer1(int OSRS, int TransferAmount, int SwapRateToOSRS)
        {
            TransferAmount = OSRS + TransferAmount / SwapRateToOSRS;
            return (OSRS, TransferAmount, SwapRateToOSRS);
        }


    }
}




