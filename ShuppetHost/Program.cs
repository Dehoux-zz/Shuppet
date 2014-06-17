using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShuppetServiceLibrary;
using System.ServiceModel;

namespace ShuppetHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ShuppetService)))
            {
                host.Open();
                Console.WriteLine("Service ready");
                Console.ReadKey();
            }
        }
    }
}
