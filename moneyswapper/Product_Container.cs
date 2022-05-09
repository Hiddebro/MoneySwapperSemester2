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
    public class Product_Container
    {
        private IProductContext ProductContext;

        public Product_Container(IProductContext context)
        {
            ProductContext = context;
        }

        public Product addProduct(int Price, int Quantity, string Name)
        {
            ProductContext.addProduct(Price, Quantity, Name);
            ProductDTO productDTO = new ProductDTO();
            productDTO.Price = Price;
            productDTO.Quantity = Quantity;
            productDTO.Name = Name;
            return new Product(productDTO);
        }
    }
}
