using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MoneySwapperrASP.ViewModels
{
        public class AccountDetailVM
        {
            public int Account_ID { get; set; }
            [Required]
            public string Username { get; set; }
            [Required]
            public string Password { get; set; }
            public List<AccountDetailVM> allaccounts { get; set; } = new List<AccountDetailVM>();
        }
    }

