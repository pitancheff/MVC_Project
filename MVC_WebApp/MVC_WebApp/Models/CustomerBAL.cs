using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebApp.Models
{
    public class CustomerBAL
    {
        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Some Customer";
            c.Address = "Some Address";
            c.Age = 55;
            return c;
        }
    }
}