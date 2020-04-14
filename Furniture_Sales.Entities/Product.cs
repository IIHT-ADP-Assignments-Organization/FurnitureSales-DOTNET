using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.Entities
{
  public  class Product
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string ProductType { get; set; }
        public virtual int Price { get; set; }
        public virtual string Pic { get; set; }
        public virtual string UsedSpan { get; set; }
        public virtual int UserId { get; set; }
    }
}
