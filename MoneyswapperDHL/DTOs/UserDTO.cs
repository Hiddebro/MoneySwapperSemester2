using System;


namespace MoneyswapperDAL.DTOs
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int OSRS { get; set; }

        public int RS3 { get; set; }
    }
}
