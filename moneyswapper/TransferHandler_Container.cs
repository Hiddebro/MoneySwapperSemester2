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
    internal class TransferHandler_Container
    {
        private ITransferHandlerContext TransferHandlerContext;

        public TransferHandler_Container(ITransferHandlerContext context)
        {
            TransferHandlerContext = context;
        }

        public TransferHandler GetSwaprate()
        {
            
            TransferHandlerDTO transferHandlerDTO = TransferHandlerContext.getSwaprate();

            return new TransferHandler(transferHandlerDTO);
        }
    }
}
