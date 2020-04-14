using Furniture_Sales.BusinessLayer.Services;
using Furniture_Sales.DataLayer.NHibernateConfiguration;
using Furniture_Sales.Entities;
using Furniture_Sales.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Furniture_Sales.Test.TestCases
{
   public class ExceptionTest
    {
        private readonly AdminServices _AdminServices;
        private readonly UserServices _UserServices;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _AdminServices = new AdminServices(_session);
            _UserServices = new UserServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFound()
        {
            User user = new User()
            {
                UserName = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _UserServices.Login(user.UserName, user.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_UserNotFoundforAdmin()
        {
            Admin admin = new Admin()
            {
                UserName = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _AdminServices.Login(admin.UserName, admin.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ProductNotFound()
        {
            Product product = new Product()
            {
                ProductId=1,
                Pic="",
                Price=1,
                ProductName="",
                ProductType="",
                UsedSpan="",
                UserId=1
            };
            //Assert
            var ex = Assert.Throws<ProductNotFoundException>(() => _UserServices.SearchProduct(product));
            Assert.Equal("Product Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_UserCannotblank()
        {
            User user = new User()
            {
                UserName = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _UserServices.Register(user));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ProductDetailsCannotblank()
        {
            Product product = new Product()
            {
                ProductId = 1,
                Pic = "",
                Price = 1,
                ProductName = "",
                ProductType = "",
                UsedSpan = "",
                UserId = 1
            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _UserServices.AddProduct(product));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }

    }
}
