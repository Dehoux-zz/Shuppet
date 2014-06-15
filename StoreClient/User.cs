using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreClient
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public double cashAmount { get; set; }

        public User(int id, string username, string password, double cashAmount)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.cashAmount = cashAmount;
        }
    }
}
