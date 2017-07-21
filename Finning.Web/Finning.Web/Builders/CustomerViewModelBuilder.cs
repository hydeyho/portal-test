using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finning.Web.Models;

namespace Finning.Web.Builders
{
    public class CustomerViewModelBuilder
    {
        public CustomerViewModel Build(Customer customer)
        {
            var viewModel = new CustomerViewModel
            {
                AccountNumber = customer.AccountNumber,
                Name = customer.Name
            };
            return viewModel;
        }

        public List<CustomerViewModel> Build(IList<Customer> customers)
        {
            return customers.Select(Build).ToList();
        }
    }
}
