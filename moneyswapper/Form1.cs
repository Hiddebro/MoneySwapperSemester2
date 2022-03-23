using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MoneyswapperDAL;




namespace moneyswapper
{

    public partial class Form1 : Form
    {

        string connectionString = "Data Source=mssqlstud.fhict.local;Initial Catalog=dbi439802_runescape;User ID=dbi439802_runescape;Password=Hidde";

        public User user = new User();
        public TransferHandler transfer = new TransferHandler();
        

        public Form1()
        {
            InitializeComponent();

            transfer.SwapRateToOSRS = 10;
            transfer.SwapRateToRS3 = 10;

            LbPreviewOsrsToRs3Swap.Text = "";
            LbPreviewRs3ToOsrsSwap.Text = "";

        }


       
        UserContext userContext = new UserContext();
        public void UserLogin2()
        {
            
            if (userContext.Login(TbUsername.Text, TbPassword.Text))
            {
                tabControl1.SelectedIndex = 1;
                var dto = userContext.getUser(TbUsername.Text);
                LbOsrsMoney.Text = dto.OSRS.ToString();
                LbRs3Money.Text = dto.RS3.ToString();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        con.Open();
            //        SqlCommand comm = new SqlCommand("SELECT * FROM UserData WHERE Username='" + TbUsername.Text + "' AND Password='" + TbPassword.Text + "'", con);
            //        SqlDataAdapter sda = new SqlDataAdapter(comm);
            //        comm.Parameters.AddWithValue("@UserID", user.UserID);
            //        comm.Parameters.AddWithValue("@Username", TbUsernameRegister.Text.Trim());
            //        comm.Parameters.AddWithValue("@Password", TbPasswordRegister.Text.Trim());
            //        comm.Parameters.AddWithValue("@Email", TbRegisterEmail.Text.Trim());
            //        comm.Parameters.AddWithValue("@OSRS", user.OSRS);
            //        comm.Parameters.AddWithValue("@RS3", user.RS3);
            //        comm.ExecuteNonQuery();
            //        DataTable dt = new DataTable();
            //        sda.Fill(dt);
            //        if (dt.Rows.Count != 0 && TbUsername.Text != "" && TbPassword.Text != "" && dt.Rows[0][0].ToString() != "0")
            //        {
            //            foreach (DataRow row in dt.Rows)

            //            {
            //                user.UserID = row.Field<int>("UserID");
            //                user.OSRS = row.Field<int>("OSRS");
            //                user.RS3 = row.Field<int>("RS3");
            //                user.Email = row.Field<string>("Email");
            //                user.Username = row.Field<string>("Username");
            //                user.Password = row.Field<string>("Password");

            //                LbOsrsMoney.Text = user.OSRS.ToString();
            //                LbRs3Money.Text = user.RS3.ToString();

            //            }
            //            tabControl1.SelectedIndex = 1;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Invalid username or password");
            //        }
            //        con.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Can not open connection ! " + ex);
            //    }
            //}

        }

        //public void UserLogin()
        //{
        //    SqlConnection con = new SqlConnection("Data Source=mssqlstud.fhict.local;Initial Catalog=dbi439802_runescape;User ID=dbi439802_runescape;Password=Hidde");

        //    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UserData WHERE Username='" + TbUsername.Text + "' AND Password='" + TbPassword.Text + "'", con);

        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    if (dt.Rows.Count != 0 && TbUsername.Text != "" && TbPassword.Text != "" && dt.Rows[0][0].ToString() != "0")
        //    {
        //        foreach (DataRow row in dt.Rows)

        //        {   
        //            user.UserID = row.Field<int>("UserID");
        //            user.OSRS = row.Field<int>("OSRS");
        //            user.RS3 = row.Field<int>("RS3");
        //            LbOsrsMoney.Text = user.OSRS.ToString();
        //            LbRs3Money.Text = user.RS3.ToString();

        //        }
        //        tabControl1.SelectedIndex = 1;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid username or password");
        //    }
        //}

        public void connection()
        {
            SqlConnection con = new SqlConnection("Data Source=mssqlstud.fhict.local;Initial Catalog=dbi439802_runescape;User ID=dbi439802_runescape;Password=Hidde");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UserData", con);
            con.Open();
            DataTable dt = new DataTable();
            MessageBox.Show(dt.Rows[3][3].ToString());
            //  MessageBox.Show("Connection Open  !");
        }


        private void BtnConnection_Click(object sender, EventArgs e)
        {
            // connection();
        }
        private void BtnOsrsToRs3_Click(object sender, EventArgs e)
        {
            if (TbOsrsMoney.Text == "Osrs amount")
            {
                MessageBox.Show("No Value given");
            }
            if ((!String.IsNullOrEmpty(TbOsrsMoney.Text)) && (TbOsrsMoney.Text != "Osrs amount"))
            {

                decimal result;
                if (decimal.TryParse(TbOsrsMoney.Text, out result))
                {
                    if (Convert.ToInt32(TbOsrsMoney.Text) != Convert.ToInt32(LbOsrsMoney.Text) && Convert.ToInt32(TbOsrsMoney.Text) >= Convert.ToInt32(LbOsrsMoney.Text))
                    {
                        MessageBox.Show("Not enough OSRS gold");
                        updateOsrsMoneyText();

                    }
                    else
                    {
                        SwapperOsrsToRs3 swapper = new SwapperOsrsToRs3();
                        (user.OSRS, user.RS3, transfer.TransferAmount, transfer.SwapRateToRS3) = swapper.OsrsToRs3(user.OSRS, user.RS3, Convert.ToInt32(TbOsrsMoney.Text), transfer.SwapRateToRS3);
                        updateOsrsMoneyText();
                        MessageBox.Show("Money has been Swapped");
                        userContext.UpdateMoney(user.UserID, user.OSRS, user.RS3);
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong please");
                }
            }


        }

        private void TbOsrsMoney_TextChanged(object sender, EventArgs e)
        {
            if (TbOsrsMoney.Text != "Osrs amount")
            {


                if (System.Text.RegularExpressions.Regex.IsMatch(TbOsrsMoney.Text, "[^0-9]"))
                {
                    TbOsrsMoney.Text = TbOsrsMoney.Text.Remove(TbOsrsMoney.Text.Length - 1);
                }

                if (TbOsrsMoney.Text != "")
                {
                    SwapperOsrsToRs3 swapper = new SwapperOsrsToRs3();
                    (user.RS3, transfer.TransferAmount, transfer.SwapRateToRS3) = swapper.transfer(user.RS3, Convert.ToInt32(TbOsrsMoney.Text), transfer.SwapRateToRS3);
                    LbPreviewOsrsToRs3Swap.Text = transfer.TransferAmount.ToString();

                }

            }
        }





        private void BtnRs3ToOsrs_Click(object sender, EventArgs e)
        {
            if (TbRs3Money.Text == "Rs3 amount")
            {
                MessageBox.Show("No Value given");
            }

            if ((!String.IsNullOrEmpty(TbRs3Money.Text)) && (TbRs3Money.Text != "Rs3 amount"))
            {

                decimal result;


                if (decimal.TryParse(TbRs3Money.Text, out result))
                {

                    if (Convert.ToInt32(TbRs3Money.Text) != Convert.ToInt32(LbRs3Money.Text) && Convert.ToInt32(TbRs3Money.Text) >= Convert.ToInt32(LbRs3Money.Text))
                    {
                        MessageBox.Show("Not enough RS3 gold");
                        updateRs3MoneyText();


                    }
                    else if (Convert.ToInt32(TbRs3Money.Text) < transfer.SwapRateToOSRS)
                    {
                        MessageBox.Show("Insufficient Balance");
                        updateRs3MoneyText();

                    }
                    else
                    {
                        SwapperRs3ToOsrs swapper = new SwapperRs3ToOsrs();
                        (user.OSRS, user.RS3, transfer.TransferAmount, transfer.SwapRateToOSRS) = swapper.Rs3ToOsrs(user.OSRS, user.RS3, Convert.ToInt32(TbRs3Money.Text), transfer.SwapRateToOSRS);
                        updateRs3MoneyText();
                        MessageBox.Show("Money has been Swapped");
                        userContext.UpdateMoney(user.UserID, user.OSRS, user.RS3);
                    }



                }
                else
                {


                    MessageBox.Show("Something went wrong please try again");

                }

            }






        }

        private void TbRs3Money_TextChanged(object sender, EventArgs e)
        {
            if (TbRs3Money.Text != "Rs3 amount")
            {



                if (System.Text.RegularExpressions.Regex.IsMatch(TbRs3Money.Text, "[^0-9]"))
                {
                    TbRs3Money.Text = TbRs3Money.Text.Remove(TbRs3Money.Text.Length - 1);
                }

                if (TbRs3Money.Text != "")
                {
                    SwapperRs3ToOsrs swapper = new SwapperRs3ToOsrs();
                    (user.OSRS, transfer.TransferAmount, transfer.SwapRateToOSRS) = swapper.transfer1(user.OSRS, Convert.ToInt32(TbRs3Money.Text), transfer.SwapRateToOSRS);
                    LbPreviewRs3ToOsrsSwap.Text = transfer.TransferAmount.ToString();

                }

            }
        }


        public void updateOsrsMoneyText()
        {
            LbOsrsMoney.Text = user.OSRS.ToString();
            LbRs3Money.Text = user.RS3.ToString();
            TbOsrsMoney.Text = "Osrs amount";
            TbOsrsMoney.ForeColor = Color.LightGray;
            LbPreviewOsrsToRs3Swap.Text = "";
        }
        public void updateRs3MoneyText()
        {
            LbOsrsMoney.Text = user.OSRS.ToString();
            LbRs3Money.Text = user.RS3.ToString();
            TbRs3Money.Text = "Rs3 amount";
            TbRs3Money.ForeColor = Color.LightGray;
            LbPreviewRs3ToOsrsSwap.Text = "";
        }

        private void TbOsrsMoney_MouseClick(object sender, MouseEventArgs e)
        {
            TbOsrsMoney.Text = "";
            TbOsrsMoney.ForeColor = Color.Black;
        }

        private void TbRs3Money_MouseClick(object sender, MouseEventArgs e)
        {
            TbRs3Money.Text = "";
            TbRs3Money.ForeColor = Color.Black;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            TbRs3Money.Text = "Rs3 amount";
            TbRs3Money.ForeColor = Color.LightGray;
            TbOsrsMoney.Text = "Osrs amount";
            TbOsrsMoney.ForeColor = Color.LightGray;
        }

        private void BtnInlog_Click(object sender, EventArgs e)
        {
            UserLogin2();

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
            tabControl1.SelectedIndex = 0;
        }

        int osrsRegister = 0;
        int rs3Register = 0;
        public void AddUser()
        {
            try
            {
                if (TbUsernameRegister.Text == "" || TbPasswordRegister.Text == "" || TbRegisterEmail.Text == "" || TbOSRSRegisterMoney.Text == "" || TbRS3RegisterMoney.Text == "")
                {
                    MessageBox.Show("please fill all fields");
                }
                else
                {

                    {
                        rs3Register = Convert.ToInt32(TbRS3RegisterMoney.Text);
                        osrsRegister = Convert.ToInt32(TbOSRSRegisterMoney.Text);
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            SqlCommand comm = new SqlCommand("UserAdd", con);
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.Parameters.AddWithValue("@Username", TbUsernameRegister.Text.Trim());
                            comm.Parameters.AddWithValue("@Password", TbPasswordRegister.Text.Trim());
                            comm.Parameters.AddWithValue("@Email", TbRegisterEmail.Text.Trim());
                            comm.Parameters.AddWithValue("@OSRS", osrsRegister);
                            comm.Parameters.AddWithValue("@RS3", rs3Register);
                            comm.ExecuteNonQuery();
                            clear();
                            MessageBox.Show("Registration is succesfull");
                            con.Close();
                        }
                    }
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }


        void clear()
        {
            TbUsernameRegister.Text = TbPasswordRegister.Text = TbRegisterEmail.Text = TbOSRSRegisterMoney.Text = TbRS3RegisterMoney.Text = "";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user.OSRS.ToString() + " veel OSRS geldje");
        }

        private void BtnShowRS3Money_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user.RS3.ToString() + " veel RS3 geldje");
        }
    }
}





