using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_Sales.Entities
{
  public  class User
    {
        public virtual int UserId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual  long PhoneNumber { get; set; }
        public virtual string Address { get; set; }

    }
}
