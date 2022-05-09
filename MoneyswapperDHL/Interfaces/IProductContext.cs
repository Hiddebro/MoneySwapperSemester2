using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyswapperDAL.DTOs;

namespace MoneyswapperDAL.Interfaces
{
    public interface IProductContext
    {
        public void addProduct(int Price, int Quantitiy, string Name);
    }
}
