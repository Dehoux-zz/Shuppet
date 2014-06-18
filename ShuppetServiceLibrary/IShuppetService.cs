using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ShuppetServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShuppetService" in both code and config file together.
    [ServiceContract]
    public interface IShuppetService
    {
        [OperationContract]
        bool Register(string username, string password);

        [OperationContract]
        bool Login(string username, string password);

        [OperationContract]
        List<Product> GetAllProducts();

        [OperationContract]
        List<Order> GetInventory(User user);

        [OperationContract]
        double CheckMoney(User user, Product product);

        [OperationContract]
        List<Product> GetProducts();
    }
}
