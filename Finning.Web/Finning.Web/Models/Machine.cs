using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finning.Web.Models
{
    public class Machine
    {
        public string SerialNumber { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int YearOfManufacture { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
