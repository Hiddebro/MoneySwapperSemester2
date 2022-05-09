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
    
    public class TransferHandlerContext : ITransferHandlerContext
    {
        static string connectionString = "Data Source=mssqlstud.fhict.local;Initial Catalog=dbi439802_runescape;User ID=dbi439802_runescape;Password=Hidde";
        public TransferHandlerDTO getSwaprate()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open(); 
                    SqlCommand comm = new SqlCommand("SELECT * FROM SwapRates", con);
                  TransferHandlerDTO transferHandlerDTO = new TransferHandlerDTO();
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        transferHandlerDTO.SwapRateToOSRS = (int)reader["ToOSRS"];
                        transferHandlerDTO.SwapRateToRS3 = (int)reader["ToRS3"];
                    }return transferHandlerDTO;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        
    }
    }
}
