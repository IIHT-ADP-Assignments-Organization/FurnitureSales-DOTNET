using Furniture_Sales.BusinessLayer.Services;
using Furniture_Sales.DataLayer.NHibernateConfiguration;
using Furniture_Sales.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Furniture_Sales.Test.TestCases
{
public class FunctionalTest
    {
        private readonly AdminServices _Adminservice;
        private readonly UserServices _Userservice;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _Adminservice = new AdminServices(_session);
            _Userservice = new UserServices(_session);
        }

        [Fact]
        public void TestFor_Valid_AdminRegister()
        {
            //Arrange
            Admin admin = new Admin()
            {
                AdminId = 1,
                AdminName = "Asha",
                UserName = "Asha123",
                Password = "12345678"

            };
            //Action
            var IsRegistered = _Adminservice.Register(admin);
            //Assert
            Assert.NotNull(IsRegistered);
        }
        [Fact]

        public void TestFor_Valid_AdminLogin()
        {
            //Arrange
            Admin admin = new Admin()
            {

                UserName = "Asha123",
                Password = "12345678",

            };
            //Action
            var IsLogined = _Adminservice.Login(admin.UserName,admin.Password);
            //Assert
            Assert.True(IsLogined);
        }

        [Fact]
        public void TestFor_AddCompany()
        {
            Company company = new Company()
            {
                CompanyId = 1,
                CompanyName = "abc",
                PhoneNumber = 989850,
                Address = "bangalore",
                AdminId = 1
            };

            var IsAdded = _Adminservice.AddCompany(company);
            var Result = IsAdded.ToString();
            //Assert
            Assert.NotNull(Result);
        }


        [Fact]
        public void TestFor_UpdateCompany()
        {
            Company company = new Company()
            {
                CompanyId = 1,
                CompanyName = "abc",
                PhoneNumber = 987850,
                Address = "bangalore",
                AdminId = 1
            };

            var IsUpdated = _Adminservice.UpdateCompany(company);
            var GetUpdated = _Adminservice.GetCompany(company.CompanyId);
            //Assert
            Assert.Equal(IsUpdated, GetUpdated);
        }

        [Fact]
        public void TestFor_DeleteCompany()
        {
            Company company = new Company()
            {
                CompanyId = 1
            };

            var IsDeleted = _Adminservice.DeleteCompany(company.CompanyId);

            //Assert
            Assert.True(IsDeleted);
        }


        //UserServicestest
        [Fact]
        public void TestFor_Valid_Register()
        {
            //Arrange
            User user = new User()
            {
                UserId = 1,
                UserName = "Asha",
                Email = "Asha123",
                Password = "12345",
                PhoneNumber = 9889878767,
                Address = "gadag"

            };
            //Action
            var IsRegistered = _Userservice.Register(user);
            //Assert
            Assert.NotNull(IsRegistered);
        }
        [Fact]

        public void TestFor_Valid_Login()
        {
            //Arrange
            User user = new User()
            {
                UserName = "Asha123",
                Password = "1234",

            };
            //Action
            var IsLogined = _Userservice.Login(user.UserName,user.Password);
            //Assert
            Assert.True(IsLogined);
        }

        [Fact]
        public void TestFor_AddProduct()
        {
            Product product = new Product()
            {
                ProductId = 1,
                ProductName = "Sofa",
                ProductType = "",
                Price = 5000,
                Pic = "",
                UsedSpan = "3 months",
                UserId = 1
            };


            var IsAdded = _Userservice.AddProduct(product);
            var Result = IsAdded.ToString();
            //Assert
            Assert.NotNull(Result);
        }


        [Fact]
        public void TestFor_UpdateProduct()
        {
            Product product = new Product()
            {
                ProductId = 1,
                ProductName = "Sofa",
                ProductType = "",
                Price = 5000,
                Pic = "",
                UsedSpan = "3 months",
                UserId = 1
            };

            var IsUpdated = _Userservice.UpdateProduct(product);
            var GetUpdated = _Userservice.GetProduct(product.ProductId);
            //Assert
            Assert.Equal(IsUpdated, GetUpdated);
        }

        [Fact]
        public void TestFor_DeleteProduct()
        {
            Product product = new Product()
            {
                ProductId = 1
            };


            var IsDeleted = _Userservice.DeleteProduct(product.ProductId);

            //Assert
            Assert.True(IsDeleted);
        }

        [Fact]
        public void TestFor_PlaceOrder()
        {
            Order order = new Order()
            {
                OrderId = 1,
                OrderDate = DateTime.Now,
                ProductId = 3,
                UserId = 1
            };


            var IsOrdered = _Userservice.PlaceOrder(order);

            //Assert
            Assert.NotNull(IsOrdered);
        }

        [Fact]
        public void TestFor_MakePayment()
        {
            Payment payment = new Payment()
            {
                PaymentId = 1,
                PaymentType = "Cash",
                Amount = 3000,
                UserId = 1
            };


            var IsPaid = _Userservice.MakePayment(payment);

            //Assert
            Assert.NotNull(IsPaid);
        }

        [Fact]
        public void TestFor_CancelOrder()
        {
            Order order = new Order()
            {
                OrderId = 1
            };


            var IsCancled = _Userservice.CancelOrder(order.OrderId);

            //Assert
            Assert.True(IsCancled);
        }

        [Fact]
        public void TestFor_SellProduct()
        {
            Product product = new Product()
            {
                ProductId = 1
            };
            Company company = new Company()
            {
                CompanyId = 1
            };


            var IsSold = _Userservice.SellProduct(product.ProductId, company.CompanyId);

            //Assert
            Assert.NotNull(IsSold);

        }
    }
}
