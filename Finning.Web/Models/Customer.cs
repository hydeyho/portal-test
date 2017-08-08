using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finning.Web.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
        public decimal CreditLimit { get; set; }
        public string Email { get; set; }
    }
}
