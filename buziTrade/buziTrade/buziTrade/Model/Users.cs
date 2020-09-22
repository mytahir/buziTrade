using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace buziTrade.Model
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FullName { get; set; }
        public string ContactAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string BusinessEmail { get; set; }
        public string Password { get; set; }
    }
}
