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

        public void addProduct(int Price, int Quantity, string Name)
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

                return;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
