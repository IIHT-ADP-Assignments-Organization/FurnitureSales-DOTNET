using Furniture_Sales.BusinessLayer.Interfaces;
using Furniture_Sales.DataLayer.NHibernateConfiguration;
using Furniture_Sales.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.BusinessLayer.Services
{
    public class UserServices : IUserServices
    {
        private readonly IMapperSession _session;

        public UserServices(IMapperSession session)
        {
            _session = session;
        }
        public int AddProduct(Product product)
        {
            Product ObjProduct = new Product();
            return ObjProduct.ProductId;
        }

        public bool CancelOrder(int OrderId)
        {
            return true;
        }

        public bool DeleteProduct(int ProductId)
        {
            return true;
        }

        public Product GetProduct(int ProductId)
        {
            Product ObjProduct = new Product();
            return ObjProduct;
        }

        public bool Login(string UserName, string Password)
        {
            return true;
        }

        public Payment MakePayment(Payment payment)
        {
            Payment ObjPayment = new Payment();
            return ObjPayment;
        }

        public Order PlaceOrder(Order order)
        {
            Order ObjOrder = new Order();
            return ObjOrder;
        }

        public User Register(User user)
        {
            User ObjUser = new User();
            return ObjUser;
        }

        public List<Product> SearchProduct(Product product)
        {
            List<Product> ObjProduct = new List<Product>();
            return ObjProduct;
        }

        public Product SellProduct(int ProductId, int CompanyId)
        {
            Product ObjProduct = new Product();
            return ObjProduct;
        }

        public Product UpdateProduct(Product product)
        {
            Product ObjProduct = new Product();
            return ObjProduct;
        }

        public Order ViewOrder()
        {
            Order ObjOrder = new Order();
            return ObjOrder;
        }
    }
}
