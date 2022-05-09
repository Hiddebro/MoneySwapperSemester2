using System;

namespace MoneySwapperrASP.Models
{
    public class TransferHandlerModel 
    {
        public int SwapRateToOSRS { get; set; }

        public int SwapRateToRS3 { get; set; }

        public int TransferAmount { get; set; }

        
        public TransferHandlerModel(int swapRateToOSRS, int swapRateToRS3, int transferAmount)
        {
            SwapRateToOSRS = swapRateToOSRS;
            SwapRateToRS3 = swapRateToRS3;
            TransferAmount = transferAmount;
        }

        public TransferHandlerModel()
        {
        }
    }




}
