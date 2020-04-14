using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.Test.Exceptions
{
   public class ProductNotFoundException:Exception
    {
        public string Messages = " Product Not Found  ";

        public ProductNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
