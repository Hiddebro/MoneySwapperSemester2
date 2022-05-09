using System;

namespace MoneySwapperrASP.Models
{
    public class ProductViewModel
    {
        public int Product_ID { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }

       public ProductViewModel(int product_ID, int price, int quantity, string name)
        {
            Product_ID = product_ID;
            Price = price;
            Quantity = quantity;
            Name = name;
        }
    }

}
