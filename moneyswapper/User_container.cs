using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyswapperDAL;

namespace moneyswapper
{
    public class User_container
    {
        UserContext userContext = new UserContext();
           
        public void GetUser()
        {
            userContext.getUser();  
        }
    }
}
