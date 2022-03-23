﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MoneyswapperDAL
{
    public class UserContext
    {
        string connectionString = "Data Source=mssqlstud.fhict.local;Initial Catalog=dbi439802_runescape;User ID=dbi439802_runescape;Password=Hidde";

        public UserDTO getUser(string username)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //try
                //{

                    con.Open();
                    SqlCommand comm = new SqlCommand("SELECT * FROM UserData WHERE Username = @username", con);

                    comm.Parameters.AddWithValue("@username", username.Trim());

                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    comm.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    var row = dt.Rows[0];

                    return new UserDTO
                    {
                        UserID = row.Field<int>("UserID"),
                        OSRS = row.Field<int>("OSRS"),
                        RS3 = row.Field<int>("RS3"),
                        Email = row.Field<string>("Email"),
                        Username = row.Field<string>("Username"),
                        Password = row.Field<string>("Password")
                    };

                }

                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
           // }
        }

        public bool Login(string username, string password)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //try
                //{
                    con.Open();
                    SqlCommand comm = new SqlCommand("SELECT * FROM UserData WHERE Username = @username AND Password = @password", con);
                    SqlDataAdapter sda = new SqlDataAdapter(comm);

                    comm.Parameters.AddWithValue("@username", username.Trim());
                    comm.Parameters.AddWithValue("@password", password.Trim());

                    comm.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);


                    con.Close();

                    return dt.Rows.Count != 0;
                }
                //catch (Exception ex)
                //{
                //   Console.WriteLine(ex.Message);
                //}

          //  }

        }
        public (int ,int, int) UpdateMoney(int userid, int osrs, int rs3)
        {
            //try
           // {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand("UPDATE UserData SET OSRS = @OSRS , RS3 = @RS3 WHERE UserID = @UserID", con);
                    comm.Parameters.AddWithValue("@UserID",  userid);
                    comm.Parameters.AddWithValue("@OSRS", osrs);
                    comm.Parameters.AddWithValue("@RS3", rs3);
                    comm.ExecuteNonQuery();
                    Console.WriteLine("Money!");
                    con.Close();

                return (userid, osrs, rs3);

               
                }
 
            }
          //  catch (Exception ex)
          //  {
            //    MessageBox.Show("Can not open connection ! " + ex);
          //  }
      //  }
    }
}

