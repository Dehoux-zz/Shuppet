using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                //Product product1 = new Product { Id = 5, name = "product5", amount = 3, price = 15.59 };
                //Product product2 = new Product { Id = 6, name = "product6", amount = 3, price = 15.59 };
                //Product product3 = new Product { Id = 7, name = "product7", amount = 3, price = 15.59 };
                //products.Add(product1);
                //products.Add(product2);
                //products.Add(product3);
                

                var query = from p in ctx.Product
                            select p;
                foreach (Product product in query)
                {
                    Debug.WriteLine("test" + product.name + product.Id + product.price + product.amount);
                    products.Add(product);
                }

                return products;
            }
        }

        public List<Product> GetProducts()
        {
            using (ShuppetModelContainer ctx = new ShuppetModelContainer())
            {
                var query = from p in ctx.Product
                            select p;
                return query.ToList();
            }
        }
        public List<Order> GetInventory(User user)
        {
            using (ShuppetModelContainer ctx = new ShuppetModelContainer())
            {
                Order order1 = new Order { Id = 1, orderDate = new DateTime(2008, 5, 1, 8, 30, 52), Product = new Product(), User = new User() };
                Order order2 = new Order { Id = 2, orderDate = new DateTime(2008, 5, 1, 8, 30, 52), Product = new Product(), User = new User() };
                Order order3 = new Order { Id = 3, orderDate = new DateTime(2008, 5, 1, 8, 30, 52), Product = new Product(), User = new User() };
                Debug.WriteLine(order1.Product);
                List<Order> orders = new List<Order>();
                orders.Add(order1);
                orders.Add(order2);
                orders.Add(order3);

                var query = from o in ctx.Order
                            select o;
                foreach (Order order in query)
                {
                    Debug.WriteLine("TESTPOINT");
                    Debug.WriteLine(order.Id + " | " + order.orderDate + " | " + order.Product.name + " | " + order.User.username);
                    orders.Add(order);
                }

                return orders;
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
