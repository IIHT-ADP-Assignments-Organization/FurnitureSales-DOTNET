using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.Entities
{
  public  class Admin
    {
        public virtual int AdminId { get; set; }
        public virtual string AdminName { get; set; }
        public virtual int PhoneNumber { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }


    }
}
