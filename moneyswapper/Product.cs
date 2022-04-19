using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyswapperDAL.DTOs;

namespace moneyswapper
{
    public class Product
    {
        public int Product_ID { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }


        public Product( int Price, int Quantitiy, string Name)
        {

        }



        public Product(ProductDTO dto)
        {
            Price = dto.Price;
            Quantity = dto.Quantity;
            Name = dto.Name;
        }

        public Product()
        {

        }

        public ProductDTO ToDTO()
        {
            return new ProductDTO
            {
                Price=Price,
                Quantity=Quantity,
                Name=Name
            };
        }
    }
}
