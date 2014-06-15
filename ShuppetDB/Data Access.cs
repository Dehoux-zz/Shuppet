using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuppetDB
{
    class DBUser
    {
        ShuppetEnt context = new ShuppetEnt();

        public DBUser(){}

        public User GetUser(User us)
        {
            var query = from dbUser in context.User
                        where dbUser == us
                        select dbUser;
            var user = query.SingleOrDefault();
            return AddOrdersToUser((User)user);
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            var query = from dbUser in context.User
                        select dbUser;
            foreach (User user in query)
            {
                AddOrdersToUser(user);
                users.Add(user);
            }
            return users;
        }

        public User GetUserById(int uId)
        {
            var query = from dbUser in context.User
                        where dbUser.Id == uId
                        select dbUser;
            var user = query.SingleOrDefault();
            return AddOrdersToUser((User)user);
        }

        public User GetUserByUsername(String uNm)
        {
            var query = from dbUser in context.User
                        where dbUser.username.Equals(uNm)
                        select dbUser;
            var user = query.SingleOrDefault();
            return AddOrdersToUser((User)user);
        }

        public bool CheckUserWallet(User us, int price)
        {
            User user = GetUser(us);
            if (Convert.ToInt32(user.cashAmount) >= price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User AddOrdersToUser(User user)
        {
            List<Order> orders = new List<Order>();
            var query = from dbOrder in context.Order
                        where dbOrder.User_Id == user.Id
                        select dbOrder;
            foreach (Order order in query)
            {
                orders.Add(order);
            }
            user.Order = orders;
            return user;
        }
    }

    class DBProduct
    {
        ShuppetEnt context = new ShuppetEnt();

        public DBProduct() { }

        public Product GetProduct(Product pr)
        {
            var query = from dbProduct in context.Product
                        where dbProduct == pr
                        select dbProduct;
            var product = query.SingleOrDefault();
            return (Product)product; 
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            var query = from dbProduct in context.Product
                        select dbProduct;
            foreach (Product product in query)
            {
                products.Add(product);
            }
            return products;
        }

        public Product GetProductById(int pId)
        {
            var query = from dbProduct in context.Product
                        where dbProduct.Id == pId
                        select dbProduct;
            var product = query.SingleOrDefault();
            return (Product)product;
        }

        public Product GetProductByName(String pNm)
        {
            var query = from dbProduct in context.Product
                        where dbProduct.Name.Equals(pNm)
                        select dbProduct;
            var product = query.SingleOrDefault();
            return (Product)product;
        }
    }

    class DBOrder
    {
        ShuppetEnt context = new ShuppetEnt();

        public Order GetOrder(Order or)
        {
            var query = from dbOrder in context.Order
                        where dbOrder == or
                        select dbOrder;
            var order = query.SingleOrDefault();
            return (Order)order;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            var query = from dbOrder in context.Order
                        select dbOrder;
            foreach (Order order in query)
            {
                orders.Add(order);
            }
            return orders;
        }

        public Order GetOrderById(int oId)
        {
            var query = from dbOrder in context.Order
                        where dbOrder.Id == oId
                        select dbOrder;
            var order = query.SingleOrDefault();
            return (Order)order;
        }

        public Order AddProductsToOrder(Order order)
        {
            List<Product> products = new List<Product>();
            List<OrderProduct> orderProducts = new List<OrderProduct>();

            var queryOP = from dbOrderProduct in context.OrderProduct
                          from dbProduct in context.Product
                          where dbOrderProduct.Order_Id == order.Id
                          select dbOrderProduct;

            foreach (OrderProduct orderProduct in queryOP)
            {
                //var queryP = from dbProduct in context.Product
                //             where dbProduct.Id == orderProduct.Product_Id
                //             select dbProduct;
                //foreach (Product product in queryP)
                //{
                //    products.Add(product);
                //}
                //orderProduct.Product = products;
                orderProducts.Add(orderProduct);
            }
            order.OrderProduct = orderProducts;

            return order;
        }
    }
}
