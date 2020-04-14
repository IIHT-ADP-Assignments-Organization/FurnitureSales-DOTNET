using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.Entities
{
   public class Payment
    {
        public virtual int PaymentId { get; set; }
        public virtual string PaymentType { get; set; }
        public virtual int Amount { get; set; }
        public virtual int UserId { get; set; }
    }
}
