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


//private static string Server = mssqlstud.fhict.local; Database = dbi439802; User Id = dbi439802; Password = Hidde;
namespace moneyswapper
{
    
    public partial class Form1 : Form
    {
     

        public User henk = new User();
        public TransferHandler transfer = new TransferHandler();

        public Form1()
        {
            InitializeComponent();

          //  henk.OSRS = 100;
          //  henk.RS3 = 100000;

            //   henk.Username = "";
            //   henk.Password = "";
            //   henk.Email = "";

            transfer.SwapRateToOSRS = 10;
            transfer.SwapRateToRS3 = 10;

            LbOsrsMoney.Text = henk.OSRS.ToString();
            LbRs3Money.Text = henk.RS3.ToString();

            LbPreviewOsrsToRs3Swap.Text = "";
            LbPreviewRs3ToOsrsSwap.Text = "";

        }

      
            
           

            //User user = new User();
            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UserData WHERE Username='" + TbUsername.Text + "' AND Password='" + TbPassword.Text + "'", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);


    

        
        
        public string conString = "Data Source=mssqlstud.fhict.local;Initial Catalog=dbi439802_runescape;User ID=dbi439802_runescape;Password=Hidde";
        private void BtnConnection_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection(conString);
           // con.Open();
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
                        (henk.OSRS, henk.RS3, transfer.TransferAmount, transfer.SwapRateToRS3) = swapper.OsrsToRs3(henk.OSRS, henk.RS3, Convert.ToInt32(TbOsrsMoney.Text), transfer.SwapRateToRS3);
                        updateOsrsMoneyText();
                        MessageBox.Show("Money has been Swapped");
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
                    (henk.RS3, transfer.TransferAmount, transfer.SwapRateToRS3) = swapper.transfer(henk.RS3, Convert.ToInt32(TbOsrsMoney.Text), transfer.SwapRateToRS3);
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
                        (henk.OSRS, henk.RS3, transfer.TransferAmount, transfer.SwapRateToOSRS) = swapper.Rs3ToOsrs(henk.OSRS, henk.RS3, Convert.ToInt32(TbRs3Money.Text), transfer.SwapRateToOSRS);
                        updateRs3MoneyText();
                        MessageBox.Show("Money has been Swapped");
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
                    (henk.OSRS, transfer.TransferAmount, transfer.SwapRateToOSRS) = swapper.transfer1(henk.OSRS, Convert.ToInt32(TbRs3Money.Text), transfer.SwapRateToOSRS);
                    LbPreviewRs3ToOsrsSwap.Text = transfer.TransferAmount.ToString();

                }

            }
        }


        public void updateOsrsMoneyText()
        {
            LbOsrsMoney.Text = henk.OSRS.ToString();
            LbRs3Money.Text = henk.RS3.ToString();
            TbOsrsMoney.Text = "Osrs amount";
            TbOsrsMoney.ForeColor = Color.LightGray;
            LbPreviewOsrsToRs3Swap.Text = "";
        }
        public void updateRs3MoneyText()
        {
            LbOsrsMoney.Text = henk.OSRS.ToString();
            LbRs3Money.Text = henk.RS3.ToString();
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
            UserLogin();
            UserMoney();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            henk.Username = TbUsernameRegister.Text;
            henk.Password = TbPasswordRegister.Text;
            henk.Email = TbRegisterEmail.Text;
            tabControl1.SelectedIndex = 0;
        }

       
    }

}





