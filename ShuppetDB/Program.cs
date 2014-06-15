using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuppetDB
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            DBUser dbUser = new DBUser();
            user = dbUser.GetUserByUsername("Nick");
            Console.WriteLine("Id: " + user.Id + "\nName: " + user.username + "\nWallet: " + user.cashAmount);
            foreach (Order order in user.Order)
            {
                Console.WriteLine("Order: " + order.Id);
            }
            Console.ReadKey();
        }
    }
}
