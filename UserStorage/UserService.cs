using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStorage
{
    public class UserService
    {
        public User GetUser(string username)
        {
            User user = new User();
            using (StoreModelContainer ctx = new StoreModelContainer())
            {
                user = ctx.UserSet.Single(u => u.Username == username);
                return user;
            }
        }


    }
}
