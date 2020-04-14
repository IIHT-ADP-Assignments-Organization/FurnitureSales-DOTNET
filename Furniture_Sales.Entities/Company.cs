using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.Entities
{
   public class Company
    {
        public virtual int CompanyId { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual int PhoneNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual int AdminId { get; set; }

    }
}
