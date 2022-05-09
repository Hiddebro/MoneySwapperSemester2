using MoneyswapperDAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyswapperDAL.Interfaces
{
    public interface ITransferHandlerContext
    {
        public TransferHandlerDTO getSwaprate();
    }
}
