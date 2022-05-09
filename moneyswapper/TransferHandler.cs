using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MoneyswapperDAL;
using MoneyswapperDAL.DTOs;

namespace moneyswapper
{

    public class TransferHandler
    {
        public int SwapRateToOSRS { get; set; }

        public int SwapRateToRS3 { get; set; }

        public int TransferAmount { get; set; }

        public TransferHandler(int swapRateToOSRS, int swapRateToRS3)
        {
            SwapRateToOSRS = swapRateToOSRS;
            SwapRateToRS3 = swapRateToRS3;
        }
        public TransferHandler()
        {

        }

        public TransferHandler(TransferHandlerDTO dto)
        {
            SwapRateToOSRS = dto.SwapRateToOSRS;
            SwapRateToRS3 = dto.SwapRateToRS3;
        }

        public TransferHandlerDTO ToDTO()
        {
            return new TransferHandlerDTO
            {
                SwapRateToOSRS = SwapRateToOSRS,
                SwapRateToRS3 = SwapRateToRS3
            };
        }
    }
}
    

