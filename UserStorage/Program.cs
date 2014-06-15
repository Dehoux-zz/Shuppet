using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StoreModelContainer ctx = new StoreModelContainer())
            {
                //Het los storen van objecten naar de DB
                //Product p1 = new Product { Name = "Appel", Price = 1.98 };
                //Product p2 = new Product { Name = "Peer", Price = 1.89 };
                //ctx.ProductSet.Add(p1);
                //ctx.ProductSet.Add(p2);
                //ctx.SaveChanges();

                //Ophalen van producten uit de DB
                //var products = from p in ctx.ProductSet
                //               select p;
                //foreach (Product p in products)
                //    Console.WriteLine("Product met ID {0}, naam {1} en prijs {2}",
                //                    p.Id,
                //                    p.Name,
                //                    p.Price);
                //Console.ReadKey();

                //User u = new User { Username = "Samme", Password = "emmaS", CashAmount = 50 };
                //Product p1 = ctx.ProductSet.Single(p => p.Name == "Appel");
                //Product p2 = ctx.ProductSet.Single(p => p.Name == "Peer");

                //OrderEntry oe1 = new OrderEntry { Amount = 3, Product = p1 };
                //OrderEntry oe2 = new OrderEntry { Amount = 2, Product = p2 };

                //Order odr1 = new Order { User = u, OrderDate = DateTime.Today };
                //odr1.OrderEntry.Add(oe1);
                //odr1.OrderEntry.Add(oe2);

                //ctx.OrderSet.Add(odr1);

                //ctx.SaveChanges();

                //Console.ReadKey();

            }

        }
    }
}
