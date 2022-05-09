using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyswapperDAL.DTOs;
using MoneyswapperDAL.Interfaces;
using BusinessLayer.Converters;
using BusinessLayer.Models;



namespace BusinessLayer.Container
{
    public class Product_Container
    {

        private IProductContext ProductContext;
        private readonly ProductConverter converter = new ProductConverter();

        public Product_Container(IProductContext context, ProductConverter uc)
        {
            ProductContext = context;
            converter = uc;
        }

        public ProductModel GetProduct(string Product_ID)
        {
            ProductDTO productDTO = ProductContext.getProduct(Product_ID);
            ProductModel model = converter.DtoToModel(productDTO);

            return model;
        }

        public ProductModel addProduct(int Price, int Quantity, string Name)
 {
     ProductDTO dto = ProductContext.addProduct(Price, Quantity, Name);
     ProductModel productModel = converter.DtoToModel(dto);
     return productModel;
 }
    }
}
