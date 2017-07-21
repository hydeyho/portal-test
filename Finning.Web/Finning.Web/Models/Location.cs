using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finning.Web.Models
{
    public class Location
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Logitude { get; set; }
        public int NumberOfMachines { get; set; }
    }
}
