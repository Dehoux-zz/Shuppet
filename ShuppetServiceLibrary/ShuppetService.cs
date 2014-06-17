using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShuppetServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShuppetService" in both code and config file together.
    public class ShuppetService : IShuppetService
    {
        public bool Register(string unm, string psw)
        {
            using (ShuppetModelContainer ctx = new ShuppetModelContainer())
            {
                if (!ctx.User.Any(us => us.username.Equals(unm)))
                {
                    string rpsw = Reverse(psw);
                    ctx.User.Add(new User { username = unm, password = rpsw });
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool Login(string username, string password)
        {
            using (ShuppetModelContainer ctx = new ShuppetModelContainer())
            {
                return ctx.User.Any(us => us.username.Equals(username) && us.password.Equals(password));
            }
        }

        public double CheckMoney(User user, Product product)
        {
            using (ShuppetModelContainer ctx = new ShuppetModelContainer())
            {
                if (Login(user.username, user.password))
                {
                    User tempUser = ctx.User.Single(us => us.username == user.username);
                    return tempUser.cashAmount;
                }
                return 0;
            }
        }

        public List<Product> GetAllProducts()
        {
            using (ShuppetModelContainer ctx = new ShuppetModelContainer())
            {
                List<Product> products = new List<Product>();
                var query = from p in ctx.Product
                               select p;
                foreach (Product product in query)
                {
                    products.Add(product);
                }
                return products;
            }
        }

        public List<Order> GetInventory(User user)
        {
            using (ShuppetModelContainer ctx = new ShuppetModelContainer())
            {

            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
