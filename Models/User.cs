using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contract_search.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}