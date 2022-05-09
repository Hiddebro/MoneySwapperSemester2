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
        public ProductDTO addProduct(int Price, int Quantity, string Name);
        public ProductDTO getProduct(string Product_ID);
    }
}
