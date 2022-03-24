using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace moneyswapper
{
    class Swapper
    {

        private TransferHandler transfer = new TransferHandler
        {
            SwapRateToOSRS = 10,
            SwapRateToRS3 = 10
        };



        public Swapper()
        {

        }

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

        public (int RS3, int TransferAmount, int SwapRateToRS3) Transfer(int RS3, int TransferAmount, int SwapRateToRS3)
        {
            TransferAmount = TransferAmount * SwapRateToRS3 + RS3;
            return (RS3, TransferAmount, SwapRateToRS3);
        }

        public (int OSRS, int TransferAmount, int SwapRateToOSRS) Transfer1(int OSRS, int TransferAmount, int SwapRateToOSRS)
        {
            TransferAmount = OSRS + TransferAmount / SwapRateToOSRS;
            return (OSRS, TransferAmount, SwapRateToOSRS);
        }
    }
}

