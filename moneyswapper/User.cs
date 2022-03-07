using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace moneyswapper
{
    public class User
    {
        public int User_id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int OSRS { get; set; }

        public int RS3 { get; set; }


        public void UserLogin()
        {

        }
    }
}
