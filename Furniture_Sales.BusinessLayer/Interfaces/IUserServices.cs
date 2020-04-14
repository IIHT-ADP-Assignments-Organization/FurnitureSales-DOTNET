using Furniture_Sales.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.BusinessLayer.Interfaces
{
    public interface IUserServices
    {
        User Register(User user);
        bool Login(string UserName, string Password);
        int AddProduct(Product product);
        Product UpdateProduct(Product product);
        Product GetProduct(int ProductId);
        bool DeleteProduct(int ProductId);
        List<Product> SearchProduct(Product product);
        Order PlaceOrder(Order order);
        Payment MakePayment(Payment payment);
        Product SellProduct(int ProductId, int CompanyId);//Add product before you sell
        Order ViewOrder();
        bool CancelOrder(int OrderId);

    }
}
