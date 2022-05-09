using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MoneyswapperDAL.DTOs;
using MoneyswapperDAL.Interfaces;


namespace MoneyswapperDAL.Context
{
    public class ProductContext : IProductContext
    {
        static string connectionString = "Data Source=mssqlstud.fhict.local;Initial Catalog=dbi439802_runescape;User ID=dbi439802_runescape;Password=Hidde";

        public ProductDTO addProduct(int Price, int Quantity, string Name)
        {
            try
            {


                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand("INSERT INTO Products (Price,Quantity,Name) VALUES (@Price,@Quantity,@Name)", con);
                    comm.Parameters.AddWithValue("@Price", Price);
                    comm.Parameters.AddWithValue("@Quantity", Quantity);
                    comm.Parameters.AddWithValue("@Name", Name);
                    comm.ExecuteNonQuery();


                    con.Close();
                }

                return addProduct(Price,Quantity,Name);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }


        }
        public ProductDTO getProduct(string Product_ID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {

                    con.Open();
                    SqlCommand comm = new SqlCommand("SELECT * FROM Products  ", con);

                    comm.Parameters.AddWithValue("Product_ID", Product_ID.Trim());

                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    comm.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    var row = dt.Rows[0];

                    return new ProductDTO
                    {
                        Product_ID = row.Field<int>("UserID"),
                        Price = row.Field<int>("OSRS"),
                        Quantity = row.Field<int>("RS3"),
                        Name = row.Field<string>("Email"),
                       
                    };
                     
        


    }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    }
}
