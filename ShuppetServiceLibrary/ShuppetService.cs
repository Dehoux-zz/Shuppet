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
                if (ctx.User.Any(us => us.username.Equals(unm)))
                {
                    string reversePass = Reverse(psw);
                    ctx.User.Add(new User { username = unm, password = psw });
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
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
