using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class TransferhandlerModel
    {
        public int SwapRateToOSRS { get; set; }

        public int SwapRateToRS3 { get; set; }

        public int TransferAmount { get; set; }

        public TransferhandlerModel(int swapRateToOSRS, int swapRateToRS3)
        {
            SwapRateToOSRS = swapRateToOSRS;
            SwapRateToRS3 = swapRateToRS3;
        }
        public TransferhandlerModel()
        {

        }
    }
}
