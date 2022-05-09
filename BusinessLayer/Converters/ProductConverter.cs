using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;
using MoneyswapperDAL.DTOs;

namespace BusinessLayer.Converters
{
    public class ProductConverter
    {
        public ProductModel DtoToModel(ProductDTO dto)
        {
            ProductModel productModel = new ProductModel()
            {
                Price = dto.Price,
                Name = dto.Name,
                 Quantity = dto.Quantity

            };
            return productModel;
        }


        public ProductDTO ModelToDTO(ProductModel model)
        {
            ProductDTO dto = new ProductDTO()
            {
                Price = model.Price,
                Name = model.Name,
                Quantity = model.Quantity

            };
            return dto;
        }
    }
}

