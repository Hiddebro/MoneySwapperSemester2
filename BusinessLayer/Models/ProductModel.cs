using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class ProductModel
    {
        public int Product_ID { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }

        public ProductModel(int price, int quantity, string name)
        {
            Price = price;
            Quantity = quantity;
            Name = name;

        }

        public ProductModel()
        {

        }
    }
}
