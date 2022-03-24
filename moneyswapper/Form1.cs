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

        public User user = new User();
        public TransferHandler transfer = new TransferHandler();
        public User_container container = new User_container();


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
                user = new User(dto);
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }
        public void connection()
        {
            SqlConnection con = new SqlConnection("Data Source=mssqlstud.fhict.local;Initial Catalog=dbi439802_runescape;User ID=dbi439802_runescape;Password=Hidde");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UserData", con);
            con.Open();
            DataTable dt = new DataTable();
            MessageBox.Show(dt.Rows[3][3].ToString());

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
                if (user.SwapOsrsToRs3(Convert.ToInt32(TbOsrsMoney.Text)))
                {
                    container.Update(user);
                    MessageBox.Show("Money has been Swapped");
                    updateOsrsMoneyText();
                }
                else
                {
                    MessageBox.Show("Not enough OSRS gold");
                    updateOsrsMoneyText();
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
                    Swapper swapper = new Swapper();
                    (user.RS3, transfer.TransferAmount, transfer.SwapRateToRS3) = swapper.Transfer(user.RS3, Convert.ToInt32(TbOsrsMoney.Text), transfer.SwapRateToRS3);
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

                if (user.SwapRs3ToOsrs(Convert.ToInt32(TbRs3Money.Text)))
                {
                    container.Update(user);
                    MessageBox.Show("Money has been Swapped");
                    updateRs3MoneyText();
                }
                else if (Convert.ToInt32(TbRs3Money.Text) < transfer.SwapRateToOSRS)
                {
                    MessageBox.Show("Insufficient Balance");
                    updateRs3MoneyText();

                }
                else
                {
                    MessageBox.Show("Not enough OSRS gold");
                    updateRs3MoneyText();
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
                    Swapper swapper = new Swapper();
                    (user.OSRS, transfer.TransferAmount, transfer.SwapRateToOSRS) = swapper.Transfer1(user.OSRS, Convert.ToInt32(TbRs3Money.Text), transfer.SwapRateToOSRS);
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
            if (TbOSRSRegisterMoney.Text != "[^0-9]" && TbRS3RegisterMoney.Text != "[^0-9]")
            {

                clear();
                MessageBox.Show("wrong input");
            }
            else
            {
                container.adduser(
                TbUsernameRegister.Text,
                TbPasswordRegister.Text,
                TbRegisterEmail.Text,
                Convert.ToInt32(TbRS3RegisterMoney.Text),
                Convert.ToInt32(TbOSRSRegisterMoney.Text)
            );
                MessageBox.Show("You have been registerd, please login");
                tabControl1.SelectedIndex = 0;
                clear();

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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}





