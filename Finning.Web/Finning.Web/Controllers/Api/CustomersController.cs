using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finning.Web.Builders;
using Finning.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finning.Web.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Customers")]
    public class CustomersController : Controller
    {
        public List<Customer> Customers { get; set; }

        public CustomersController()
        {
            Customers = new List<Customer>
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
                }
            };
        }

        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(List<CustomerViewModel>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var builder = new CustomerViewModelBuilder();
            var result = builder.Build(Customers);
            return Ok(result);
        }

        [HttpGet]
        [Route("{accountNumber}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Customer), StatusCodes.Status200OK)]
        public IActionResult Get(string accountNumber)
        {
            var result = Customers.SingleOrDefault(customer => customer.AccountNumber == accountNumber);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}