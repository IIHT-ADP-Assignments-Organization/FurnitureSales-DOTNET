using Furniture_Sales.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace Furniture_Sales.Test.TestCases
{
  public  class BoundaryTest
    {
        [Fact]
        public void Boundary_Testfor_ValidEmail()
        {
            //Action
            var customer = new User()
            {

                Email = "abc@gmail.com",

            };

            bool isEmail = Regex.IsMatch(customer.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
        }

        [Fact]
        public void Boundary_Testfor_ValidContactNumber()
        {
            //Action
            var user = new User()
            {


                PhoneNumber = 12345678
            };

            //Assert
            Assert.Equal(10, user.PhoneNumber.ToString().Length);
        }

        [Fact]
        public void BoundaryTest_ForPassword_LengthforUser()
        {
            var user = new User()
            {

                Password = "12345678"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = user.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForPassword_LengthforAdmin()
        {
            var admin = new Admin()
            {

                Password = "12345678"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = admin.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserName_LengthforUser()
        {
            //Arrange
            var user = new User()
            {

                UserName = "Rose",

            };
            var MinLength = 2;
            var MaxLength = 50;

            //Action
            var actualLength = user.UserName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
    }
}
