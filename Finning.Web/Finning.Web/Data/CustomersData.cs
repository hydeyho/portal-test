using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finning.Web.Models;

namespace Finning.Web.Data
{
    public static class CustomersData
    {
        public static List<Customer> Get()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Name = "Special Customer",
                    AccountNumber = "ABC123",
                    Address1 = "123 Special Road",
                    Address2 = "London",
                    PostCode = "W1 1AA",
                    CreditLimit = 1000000,
                    Email = "theboss@specialcompany.com"
                },
                new Customer
                {
                    Name = "Basic Customer",
                    AccountNumber = "DEF456",
                    Address1 = "321 Basic Lane",
                    Address2 = "Manchester",
                    PostCode = "M1 1AA",
                    CreditLimit = 250000,
                    Email = "theboss@basiccompany.com"
                },
                new Customer
                {
                    Name = "Normal Customer",
                    AccountNumber = "GHI789",
                    Address1 = "123 Normal Street",
                    Address2 = "Glasgow",
                    PostCode = "G1 1AA",
                    CreditLimit = 500000,
                    Email = "theboss@normalcompany.com"
                }
            };
        }
    }
}
