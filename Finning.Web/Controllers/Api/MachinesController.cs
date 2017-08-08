using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finning.Web.Builders;
using Finning.Web.Data;
using Finning.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Finning.Web.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Machines")]

    /*In regards to including a new C# endpoint, I would have to use a web service or implement a web service into this portal as well as provide
     * location variables for customer and machine within MachinesData.cs and CustomersData.cs to return the list of LocationsData object so the location
     can be viewed. However, I am unfamiliar of how I would code this.*/
    public class MachinesController : Controller
    {
        public List<Machine> Machines { get; set; }

        public MachinesController()
        {
            Machines = MachinesData.Get();
        }

        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(List<MachineViewModel>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var builder = new MachineViewModelBuilder();
            var result = builder.Build(Machines);
            return Ok(result);
        }

        [HttpGet]
        [Route("{serialNumber}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Machine), StatusCodes.Status200OK)]
        public IActionResult Get(string serialNumber)
        {
            var result = Machines.SingleOrDefault(customer => customer.SerialNumber == serialNumber);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}