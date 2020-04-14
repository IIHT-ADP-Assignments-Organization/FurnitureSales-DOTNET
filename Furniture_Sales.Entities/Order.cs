using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.Entities
{
   public class Order
    {
        public virtual int OrderId { get; set; }
        public virtual  DateTime OrderDate { get; set; }
        public virtual  int ProductId { get; set; }
        public virtual int UserId { get; set; }
        public virtual string Status { get; set; }
    }
}
